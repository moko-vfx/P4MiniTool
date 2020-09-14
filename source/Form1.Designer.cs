namespace MT_P4MiniTool
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnRevert = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.gbDropArea = new System.Windows.Forms.GroupBox();
			this.lblFilePath = new System.Windows.Forms.Label();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.pbFileStatus = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFileStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.pnlTop.Controls.Add(this.btnRevert);
			this.pnlTop.Controls.Add(this.btnConnect);
			this.pnlTop.Controls.Add(this.btnSubmit);
			this.pnlTop.Controls.Add(this.btnEdit);
			this.pnlTop.Controls.Add(this.btnSettings);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(424, 40);
			this.pnlTop.TabIndex = 0;
			// 
			// btnRevert
			// 
			this.btnRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnRevert.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Revert;
			this.btnRevert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRevert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnRevert.FlatAppearance.BorderSize = 0;
			this.btnRevert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnRevert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRevert.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnRevert.Location = new System.Drawing.Point(121, 8);
			this.btnRevert.Name = "btnRevert";
			this.btnRevert.Size = new System.Drawing.Size(23, 23);
			this.btnRevert.TabIndex = 4;
			this.btnRevert.TabStop = false;
			this.toolTip1.SetToolTip(this.btnRevert, "ファイルをリバートします\\n（(チェックアウト前に戻します）");
			this.btnRevert.UseVisualStyleBackColor = false;
			this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
			this.btnRevert.MouseEnter += new System.EventHandler(this.btnRevert_MouseEnter);
			this.btnRevert.MouseLeave += new System.EventHandler(this.btnRevert_MouseLeave);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnConnect.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Connect;
			this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnConnect.FlatAppearance.BorderSize = 0;
			this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConnect.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnConnect.Location = new System.Drawing.Point(13, 8);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(23, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.TabStop = false;
			this.toolTip1.SetToolTip(this.btnConnect, "ワークスペースに接続 / 接続解除します");
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
			this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSubmit.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Submit;
			this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnSubmit.Location = new System.Drawing.Point(157, 8);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(23, 23);
			this.btnSubmit.TabIndex = 5;
			this.btnSubmit.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSubmit, "チェックアウトしたファイルをサブミットします");
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
			this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnEdit.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Edit;
			this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnEdit.Location = new System.Drawing.Point(85, 8);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.TabStop = false;
			this.toolTip1.SetToolTip(this.btnEdit, "ファイルをチェックアウトします");
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
			this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
			// 
			// btnSettings
			// 
			this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSettings.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Set;
			this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnSettings.Location = new System.Drawing.Point(49, 8);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(23, 23);
			this.btnSettings.TabIndex = 2;
			this.btnSettings.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSettings, "ツール設定ウインドウを開きます");
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
			this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
			// 
			// gbDropArea
			// 
			this.gbDropArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbDropArea.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbDropArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(183)))));
			this.gbDropArea.Location = new System.Drawing.Point(17, 44);
			this.gbDropArea.Name = "gbDropArea";
			this.gbDropArea.Size = new System.Drawing.Size(391, 105);
			this.gbDropArea.TabIndex = 6;
			this.gbDropArea.TabStop = false;
			this.gbDropArea.Text = "Drop File Here";
			this.toolTip1.SetToolTip(this.gbDropArea, "ここに編集したいファイルを１つドロップしてください");
			this.gbDropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.gbDropArea_DragDrop);
			this.gbDropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.gbDropArea_DragEnter);
			// 
			// lblFilePath
			// 
			this.lblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFilePath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(183)))));
			this.lblFilePath.Location = new System.Drawing.Point(37, 159);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(372, 16);
			this.lblFilePath.TabIndex = 7;
			this.lblFilePath.Text = "↑ バージョン管理下のファイルを１つ放り込んで下さい。";
			// 
			// tbComment
			// 
			this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbComment.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbComment.Location = new System.Drawing.Point(18, 185);
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new System.Drawing.Size(388, 25);
			this.tbComment.TabIndex = 8;
			this.tbComment.TabStop = false;
			this.tbComment.Text = "～～を更新しました";
			this.toolTip1.SetToolTip(this.tbComment, "サブミット時のコメントを入力してください");
			// 
			// pbFileStatus
			// 
			this.pbFileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pbFileStatus.BackgroundImage = global::MT_P4MiniTool.Properties.Resources.icon_Stat_None;
			this.pbFileStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFileStatus.Location = new System.Drawing.Point(11, 156);
			this.pbFileStatus.Name = "pbFileStatus";
			this.pbFileStatus.Size = new System.Drawing.Size(24, 24);
			this.pbFileStatus.TabIndex = 10;
			this.pbFileStatus.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(424, 224);
			this.Controls.Add(this.pbFileStatus);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.gbDropArea);
			this.Controls.Add(this.lblFilePath);
			this.Controls.Add(this.tbComment);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(600, 400);
			this.MinimumSize = new System.Drawing.Size(210, 222);
			this.Name = "Form1";
			this.Text = "P4 Mini Tool v.1.00";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbFileStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRevert;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.PictureBox pbFileStatus;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.GroupBox gbDropArea;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

