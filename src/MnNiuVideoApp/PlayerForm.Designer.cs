namespace MnNiuVideo
{
    partial class PlayerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AllCamera = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PlayAddressComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.StartPlayStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DesktopRecordStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiveRecordStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 51);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllCamera,
            this.toolStripComboBox1,
            this.toolStripLabel1,
            this.PlayAddressComboBox,
            this.toolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AllCamera
            // 
            this.AllCamera.Name = "AllCamera";
            this.AllCamera.Size = new System.Drawing.Size(56, 22);
            this.AllCamera.Text = "所有相机";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "播放地址";
            // 
            // PlayAddressComboBox
            // 
            this.PlayAddressComboBox.Name = "PlayAddressComboBox";
            this.PlayAddressComboBox.Size = new System.Drawing.Size(250, 25);
            this.PlayAddressComboBox.Text = "rtmp://127.0.0.1:20050/myapp/test";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartPlayStripMenuItem,
            this.DesktopRecordStripMenuItem,
            this.LiveRecordStripMenuItem});
            this.toolStripDropDownButton.Image = global::MnNiuVideo.Properties.Resources.resizeApi__2_;
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // StartPlayStripMenuItem
            // 
            this.StartPlayStripMenuItem.Name = "StartPlayStripMenuItem";
            this.StartPlayStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartPlayStripMenuItem.Text = "开始播放";
            this.StartPlayStripMenuItem.Click += new System.EventHandler(this.StartPlayStripMenuItem_Click);
            // 
            // DesktopRecordStripMenuItem
            // 
            this.DesktopRecordStripMenuItem.Name = "DesktopRecordStripMenuItem";
            this.DesktopRecordStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DesktopRecordStripMenuItem.Text = "桌面录屏";
            this.DesktopRecordStripMenuItem.Click += new System.EventHandler(this.DesktopRecordStripMenuItem_Click);
            // 
            // LiveRecordStripMenuItem
            // 
            this.LiveRecordStripMenuItem.Name = "LiveRecordStripMenuItem";
            this.LiveRecordStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LiveRecordStripMenuItem.Text = "直播录屏";
            this.LiveRecordStripMenuItem.Click += new System.EventHandler(this.LiveRecordStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.WindowsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.StartLiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // WindowsToolStripMenuItem
            // 
            this.WindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowsResetToolStripMenuItem});
            this.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem";
            this.WindowsToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.WindowsToolStripMenuItem.Text = "窗口";
            // 
            // WindowsResetToolStripMenuItem
            // 
            this.WindowsResetToolStripMenuItem.Name = "WindowsResetToolStripMenuItem";
            this.WindowsResetToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.WindowsResetToolStripMenuItem.Text = "重置窗口";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeHelpToolStripMenuItem,
            this.CheckUpdateToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // SeeHelpToolStripMenuItem
            // 
            this.SeeHelpToolStripMenuItem.Name = "SeeHelpToolStripMenuItem";
            this.SeeHelpToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SeeHelpToolStripMenuItem.Text = "查看帮助";
            // 
            // CheckUpdateToolStripMenuItem
            // 
            this.CheckUpdateToolStripMenuItem.Name = "CheckUpdateToolStripMenuItem";
            this.CheckUpdateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.CheckUpdateToolStripMenuItem.Text = "检查更新";
            // 
            // StartLiveToolStripMenuItem
            // 
            this.StartLiveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartLiveToolStripMenuItem.Image = global::MnNiuVideo.Properties.Resources.resizeApi;
            this.StartLiveToolStripMenuItem.Name = "StartLiveToolStripMenuItem";
            this.StartLiveToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.StartLiveToolStripMenuItem.Text = "开始直播";
            this.StartLiveToolStripMenuItem.Click += new System.EventHandler(this.StartLiveToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Image = global::MnNiuVideo.Properties.Resources._10;
            this.pic.Location = new System.Drawing.Point(0, 51);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(775, 509);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 560);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerForm";
            this.Text = "迷你牛";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeeHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox PlayAddressComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem StartPlayStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DesktopRecordStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LiveRecordStripMenuItem;
        private System.Windows.Forms.ToolStripLabel AllCamera;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem StartLiveToolStripMenuItem;
    }
}

