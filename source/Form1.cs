using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perforce.P4;

namespace MT_P4MiniTool
{
	public partial class Form1 : Form
	{
		string P4PORT;
		string P4USER;
		string P4PASSWD;
		string P4CLIENT;

		string editFilePath;
		string comment;
        bool isAutoConnect;
        bool isAutoCheckout;
		bool connected = false;
        bool isCheckout = false;

        Repository p4;
		Connection con;
		Changelist myChange;


		public Form1()
		{
			InitializeComponent();
		}

        // Load Evnet
		private void Form1_Load(object sender, EventArgs e)
		{
			// Load properties
			P4PORT = Properties.Settings.Default.memP4PORT;
			P4USER = Properties.Settings.Default.memP4USER;
			P4PASSWD = Properties.Settings.Default.memP4PASSWD;
			P4CLIENT = Properties.Settings.Default.memP4CLIENT;
			comment = Properties.Settings.Default.memComment;
            isAutoConnect = Properties.Settings.Default.memIsAutoConnect;
            isAutoCheckout = Properties.Settings.Default.memIsAutoCheckout;

            DisableFileEdit();

			if (isAutoConnect)
			{
                ConnectWS();
			}
        }

		// Close Event
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Save properties
			Properties.Settings.Default.memP4PORT = P4PORT;
			Properties.Settings.Default.memP4USER = P4USER;
			Properties.Settings.Default.memP4PASSWD = P4PASSWD;
			Properties.Settings.Default.memP4CLIENT = P4CLIENT;
			Properties.Settings.Default.memComment = comment;
            Properties.Settings.Default.memIsAutoConnect = isAutoConnect;
            Properties.Settings.Default.memIsAutoCheckout = isAutoCheckout;
            Properties.Settings.Default.Save();
		}


        // ------------------- //
        // Function Difinition //
        // ------------------- //

        public void OpenFormCon()
        {
            var formCon = new FormConnect(P4PORT, P4USER, P4PASSWD, P4CLIENT, isAutoConnect, isAutoCheckout);

            // Show center of this form
            formCon.StartPosition = FormStartPosition.Manual;
            formCon.Location = new Point(this.Location.X + 30, this.Location.Y + 50);

            // Show using modal window
            DialogResult result = formCon.ShowDialog();

            // Close form with OK
            if (result == DialogResult.OK)
            {
                P4PORT = formCon.tbServer.Text;
                P4USER = formCon.tbUser.Text;
                P4PASSWD = formCon.tbPassword.Text;
                P4CLIENT = formCon.tbWorkspace.Text;
                isAutoConnect = formCon.cbAutoConnect.Checked;
                isAutoCheckout = formCon.cbAutoCheckout.Checked;
            }

            formCon.Dispose();
        }

        public void ConnectWS()
        {
            Server srv = new Server(new ServerAddress(P4PORT));
            p4 = new Repository(srv);

            con = p4.Connection;
            con.UserName = P4USER;
            con.Client = new Client();
            con.Client.Name = P4CLIENT;

            connected = con.Connect(null);
            if (connected)
            {
                try
                {
                    // Attempt a Login
                    Credential cred = con.Login(P4PASSWD);
                    
                    // Get workspace name
                    ClientsCmdOptions opts = new ClientsCmdOptions(ClientsCmdFlags.None, P4USER, null, 10, null);
                    IList<Client> clients = p4.GetClients(opts);

                    var wsList = new List<string>();

                    foreach (var client in clients)
					{
                        wsList.Add(client.Name.ToString());
                    }

                    // Check to exist the workspace
					if (wsList.Contains(P4CLIENT))
					{
                        btnConnect.BackgroundImage = Properties.Resources.icon_Connect_On;
                        gbDropArea.AllowDrop = true;

                        Console.WriteLine("Connected!");
                    }
					else
					{
                        DisconnectWS();

                        MessageBox.Show(P4CLIENT + " は存在しないワークスペースです。\n" +
                                        "設定を確認してください。");
                        Console.WriteLine("The workspace doesn't exist!");

                        OpenFormCon();
                    }
                }
                catch (P4Exception e)
                {
                    connected = false;
                    btnConnect.BackgroundImage = Properties.Resources.icon_Connect;

                    MessageBox.Show("接続に失敗しました。\n設定を確認してください");
                    Console.WriteLine("Couldn't connect P4-Server!\n {0} : {1}", e.ErrorCode, e.Message);

                    OpenFormCon();
                }
            }
        }

        public void DisconnectWS()
        {
            try
            {
                connected = con.Connect(null);
                if (connected)
                {
                    con.Disconnect();

                    connected = false;
                    btnConnect.BackgroundImage = Properties.Resources.icon_Connect;

                    DisableFileEdit();
                    editFilePath = null;
                    lblFilePath.Text = "↑ バージョン管理下のファイルを１つ放り込んで下さい。";
                    gbDropArea.AllowDrop = false;

                    Console.WriteLine("Disconnected!");
                }
            }
            catch (P4Exception e)
            {
                MessageBox.Show("切断できませんでした。");
                Console.WriteLine("Couldn't disconnect P4-Server!\n {0} : {1}", e.ErrorCode, e.Message);
            }
        }

        public bool ChkFileIsWSRoot()
        {
            // Get workspace name
            string rootPath = con.Client.Root.ToString();

            // Check to exist the workspace
            if (editFilePath.StartsWith(rootPath, true, CultureInfo.CurrentCulture))
            {
                Console.WriteLine("The file exists on the workspace!");
                return (true);
            }
            else
            {
                MessageBox.Show(editFilePath + " は\n" + rootPath + " 以下に存在しません。\n" +
                                "バージョン管理下のファイルか確認してください。");
                Console.WriteLine("The file doesn't exist on the workspace.");

                DisableFileEdit();
                lblFilePath.Text = "↑ バージョン管理下のファイルを１つ放り込んで下さい。";
                return (false);
            }
		}

        public bool ChkFileIsManaged()
        {
            FileSpec editFile = new FileSpec(new LocalPath(editFilePath));
            IList<FileSpec> depotFiles = p4.GetDepotFiles(new FileSpec[] { editFile }, new Options());

            if (depotFiles != null)
            {
                lblFilePath.Text = editFilePath;

                Console.WriteLine("The file is in version control!");
                return (true);
            }
			else
			{
                DisableFileEdit();
                lblFilePath.Text = "↑ バージョン管理下のファイルを１つ放り込んで下さい。";

                MessageBox.Show("バージョン管理されているファイルではありません。");
                Console.WriteLine("The file isn't in version control!");
                return (false);
            }
        }

        public bool ChkIsCheckout()
        {
			FileSpec editFile = new FileSpec(new LocalPath(editFilePath));
			IList<FileSpec> depotFiles = p4.GetDepotFiles(new FileSpec[] { editFile }, new Options());

            if (depotFiles != null)
            {
                Console.WriteLine(depotFiles[0]);

                List<FileSpec> lfs = new List<FileSpec>();
                lfs.Add(depotFiles[0].DepotPath);

                GetOpenedFilesOptions opts = new GetOpenedFilesOptions(
                    GetOpenedFilesCmdFlags.AllClients, null, null, null, 10);
                IList<Perforce.P4.File> openedFiles = p4.GetOpenedFiles(lfs, opts);

                if (openedFiles != null)
                {
                    DisableFileEdit();
                    lblFilePath.Text = "↑ バージョン管理下のファイルを１つ放り込んで下さい。";

                    MessageBox.Show("すでにチェックアウトされているファイルです。\n" +
                                    "チェンジリスト作成の都合のため、本ツール上でチェックアウトしてください。");
                    Console.WriteLine("The file has already been checkout!");
                    return (true);
                }
                else
                {
                    EnableFileEdit();

                    Console.WriteLine("The file hasn't been checkout!");
                    return (false);
                }
            }
			else
			{
                return (false);
            }
        }

        public void EnableFileEdit()
        {
            btnEdit.BackgroundImage = Properties.Resources.icon_Edit;
            btnRevert.BackgroundImage = Properties.Resources.icon_Revert_disable;
            btnSubmit.BackgroundImage = Properties.Resources.icon_Submit_disable;
            btnEdit.Enabled = true;
            btnRevert.Enabled = false;
            btnSubmit.Enabled = false;
            pbFileStatus.BackgroundImage = Properties.Resources.icon_Stat_Manage;
            isCheckout = false;
        }
        public void EnableFileSubmit()
        {
            btnEdit.BackgroundImage = Properties.Resources.icon_Edit_disable;
            btnRevert.BackgroundImage = Properties.Resources.icon_Revert;
            btnSubmit.BackgroundImage = Properties.Resources.icon_Submit;
            btnEdit.Enabled = false;
            btnRevert.Enabled = true;
            btnSubmit.Enabled = true;
            pbFileStatus.BackgroundImage = Properties.Resources.icon_Stat_Edit;
            isCheckout = true;
        }
        public void DisableFileEdit()
        {
            btnEdit.BackgroundImage = Properties.Resources.icon_Edit_disable;
            btnRevert.BackgroundImage = Properties.Resources.icon_Revert_disable;
            btnSubmit.BackgroundImage = Properties.Resources.icon_Submit_disable;
            btnEdit.Enabled = false;
            btnRevert.Enabled = false;
            btnSubmit.Enabled = false;
            pbFileStatus.BackgroundImage = Properties.Resources.icon_Stat_None;
        } 

        public void EditFile()
        {
            if (System.IO.File.Exists(editFilePath))
            {
                connected = con.Connect(null);
                if (connected)
                {
                    // Checking the file if it's in version control
					if (ChkFileIsManaged())
					{
                        try
                        {
                            string deaultfComment = "補助ツールによるチェックアウト";

                            // Create a new custom changelist
                            myChange = new Changelist();
                            myChange.Description = deaultfComment;
                            myChange = p4.CreateChangelist(myChange);

                            FileSpec editFile = new FileSpec(new LocalPath(editFilePath));
                            Options editOptions = new Options();
                            editOptions["-c"] = String.Format("{0}", myChange.Id);

                            try
                            {
                                // Open the file for edit
                                p4.Connection.Client.EditFiles(editOptions, new FileSpec[] { editFile });

                                EnableFileSubmit();

                                Console.WriteLine("The file is checkout!");
                            }
                            catch (P4Exception e)
                            {
                                MessageBox.Show("チェックアウトに失敗しました。\n" +
                                            "すでにチェックアウトされていないか確認してください。");
                                Console.WriteLine("Couldn't open file for edit!\n {0} : {1}", e.ErrorCode, e.Message);
                            }
                        }
                        catch (P4Exception e)
                        {
                            MessageBox.Show("チェンジリスト作成に失敗しました。\n" +
                                            "バージョン管理されているファイルか確認してください。");
                            Console.WriteLine("Couldn't make new changelist!\n {0} : {1}", e.ErrorCode, e.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ワークスペースに正しく接続できているか確認してください。");
                }
            }
            else
            {
                MessageBox.Show("指定ファイルが存在しません。");
            }
        }

        public void RevertFile()
        {
            if (System.IO.File.Exists(editFilePath))
            {
                connected = con.Connect(null);
                if (connected)
                {
                    try
                    {
                        FileSpec rivertFile = new FileSpec(new LocalPath(editFilePath));
                        Options rivertOptions = new Options();
                        p4.Connection.Client.RevertFiles(rivertOptions, new FileSpec[] { rivertFile });

                        EnableFileEdit();

                        Console.WriteLine("The file is reverted!");
                    }
                    catch (P4Exception e)
                    {
                        MessageBox.Show("リバートに失敗しました。");
                        Console.WriteLine("Couldn't revert file!\n {0} : {1}", e.ErrorCode, e.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ワークスペースに正しく接続できているか確認してください。");
                }
            }
            else
            {
                MessageBox.Show("指定ファイルが存在しません。");
            }
        }

        public void SubmitFile()
        {
            connected = con.Connect(null);
            if (connected)
            {
                try
                {
                    // Submit the edit
                    comment = tbComment.Text;
                    myChange = p4.GetChangelist(myChange.Id);
                    myChange.Description = comment;
                    p4.UpdateChangelist(myChange);
                    myChange.Submit(new Options());

                    EnableFileEdit();

                    Console.WriteLine("The file is submitted!");
                }
                catch (P4Exception e)
                {
                    MessageBox.Show("サブミットに失敗しました。\n" +
                                    "正常にチェックアウトされているファイルか確認してください。");
                    Console.WriteLine("Couldn't submit file!\n {0} : {1}", e.ErrorCode, e.Message);
                }
            }
            else
            {
                MessageBox.Show("ワークスペースに正しく接続できているか確認してください。");
            }
        }


        // Get one file path using drag&drop
        private void gbDropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }       
        }
        private void gbDropArea_DragDrop(object sender, DragEventArgs e)
        {
            string[] multiPass = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            editFilePath = multiPass[0];

            // Get the path of the referenced file if it's a short-cut
            string extension = Path.GetExtension(editFilePath);
            if (".lnk" == extension)
            {
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                // Get short-cut object
                IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(editFilePath);
                // Get file from short-cut object
                editFilePath = shortcut.TargetPath.ToString();
            }

            if (ChkFileIsWSRoot())
			{
				if (ChkFileIsManaged())
				{
					if (!ChkIsCheckout())
					{
                        if (isAutoCheckout)
                        {
                            EditFile();
                        }
                    }
                }
            }
        }


        // ------------------ //
        // Click Button Event //
        // ------------------ //

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                DisconnectWS();
            }
            else
            {
                ConnectWS();
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenFormCon();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditFile();
        }
        private void btnRevert_Click(object sender, EventArgs e)
        {
            RevertFile();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitFile();
        }

        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            if (!connected)
            {
                btnConnect.BackgroundImage = Properties.Resources.icon_Connect_Active;
            }
        }
        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            if (!connected)
            {
                btnConnect.BackgroundImage = Properties.Resources.icon_Connect;
            }
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.icon_Set_Active;
        }
        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.icon_Set;
        }
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
			if (!isCheckout)
			{
                btnEdit.BackgroundImage = Properties.Resources.icon_Edit_Active;
            }
        }
        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            if (!isCheckout)
            {
                btnEdit.BackgroundImage = Properties.Resources.icon_Edit;
            }
        }
        private void btnRevert_MouseEnter(object sender, EventArgs e)
        {
            if (isCheckout)
            {
                btnRevert.BackgroundImage = Properties.Resources.icon_Revert_Active;
            }
        }
        private void btnRevert_MouseLeave(object sender, EventArgs e)
        {
            if (isCheckout)
            {
                btnRevert.BackgroundImage = Properties.Resources.icon_Revert;
            }
        }
        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            if (isCheckout)
            {
                btnSubmit.BackgroundImage = Properties.Resources.icon_Submit_Active;
            }
        }
        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            if (isCheckout)
            {
                btnSubmit.BackgroundImage = Properties.Resources.icon_Submit;
            }
        }
	}
}
