namespace MT_P4MiniTool
{
	partial class FormConnect
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbWorkspace = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.cbAutoConnect = new System.Windows.Forms.CheckBox();
			this.cbAutoCheckout = new System.Windows.Forms.CheckBox();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnCancel.Location = new System.Drawing.Point(275, 167);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(60, 28);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnOK.Location = new System.Drawing.Point(207, 167);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(60, 28);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(19, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Workspace:";
			// 
			// tbWorkspace
			// 
			this.tbWorkspace.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbWorkspace.Location = new System.Drawing.Point(119, 102);
			this.tbWorkspace.Name = "tbWorkspace";
			this.tbWorkspace.Size = new System.Drawing.Size(217, 25);
			this.tbWorkspace.TabIndex = 8;
			this.tbWorkspace.Text = "workspace name";
			this.toolTip2.SetToolTip(this.tbWorkspace, "接続先のワークスペース名を入力します");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(19, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbPassword.Location = new System.Drawing.Point(119, 72);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(217, 25);
			this.tbPassword.TabIndex = 6;
			this.tbPassword.Text = "1234";
			this.toolTip2.SetToolTip(this.tbPassword, "ユーザーのパスワードを入力します");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(19, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "User:";
			// 
			// tbUser
			// 
			this.tbUser.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbUser.Location = new System.Drawing.Point(119, 42);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(217, 25);
			this.tbUser.TabIndex = 4;
			this.tbUser.Text = "user name";
			this.toolTip2.SetToolTip(this.tbUser, "ユーザー名を入力します");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(19, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server:";
			// 
			// tbServer
			// 
			this.tbServer.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbServer.Location = new System.Drawing.Point(119, 12);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(217, 25);
			this.tbServer.TabIndex = 2;
			this.tbServer.Text = "1666";
			this.toolTip2.SetToolTip(this.tbServer, "接続先のサーバーのアドレスを入力します");
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(5, 205);
			this.pnlLeft.TabIndex = 0;
			// 
			// cbAutoConnect
			// 
			this.cbAutoConnect.AutoSize = true;
			this.cbAutoConnect.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.cbAutoConnect.Location = new System.Drawing.Point(23, 141);
			this.cbAutoConnect.Name = "cbAutoConnect";
			this.cbAutoConnect.Size = new System.Drawing.Size(115, 24);
			this.cbAutoConnect.TabIndex = 9;
			this.cbAutoConnect.Text = "Auto Connect";
			this.toolTip2.SetToolTip(this.cbAutoConnect, "起動時に自動で接続します");
			this.cbAutoConnect.UseVisualStyleBackColor = true;
			// 
			// cbAutoCheckout
			// 
			this.cbAutoCheckout.AutoSize = true;
			this.cbAutoCheckout.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.cbAutoCheckout.Location = new System.Drawing.Point(23, 168);
			this.cbAutoCheckout.Name = "cbAutoCheckout";
			this.cbAutoCheckout.Size = new System.Drawing.Size(122, 24);
			this.cbAutoCheckout.TabIndex = 10;
			this.cbAutoCheckout.Text = "Auto Checkout";
			this.toolTip2.SetToolTip(this.cbAutoCheckout, "ツール上にファイルをドロップ時に自動でチェックアウトします");
			this.cbAutoCheckout.UseVisualStyleBackColor = true;
			// 
			// FormConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.ClientSize = new System.Drawing.Size(349, 205);
			this.Controls.Add(this.cbAutoCheckout);
			this.Controls.Add(this.cbAutoConnect);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbWorkspace);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.pnlLeft);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConnect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Connect Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox tbWorkspace;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Panel pnlLeft;
		private System.Windows.Forms.ToolTip toolTip2;
		public System.Windows.Forms.CheckBox cbAutoConnect;
		public System.Windows.Forms.CheckBox cbAutoCheckout;
	}
}