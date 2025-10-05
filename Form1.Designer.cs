namespace Lab03_02
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LuuNoiDungVanBanToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.TaoVanBanMoiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MoTapTinToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoVanBanMoiToolStrip,
            this.MoTapTinToolStrip,
            this.LuuNoiDungVanBanToolStrip,
            this.ThoatToolStrip});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // LuuNoiDungVanBanToolStrip
            // 
            this.LuuNoiDungVanBanToolStrip.Image = global::Lab03_02.Properties.Resources.images;
            this.LuuNoiDungVanBanToolStrip.Name = "LuuNoiDungVanBanToolStrip";
            this.LuuNoiDungVanBanToolStrip.Size = new System.Drawing.Size(235, 26);
            this.LuuNoiDungVanBanToolStrip.Text = "Lưu nội dung văn bản";
            this.LuuNoiDungVanBanToolStrip.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ThoatToolStrip
            // 
            this.ThoatToolStrip.Name = "ThoatToolStrip";
            this.ThoatToolStrip.Size = new System.Drawing.Size(235, 26);
            this.ThoatToolStrip.Text = "Thoát";
            this.ThoatToolStrip.Click += new System.EventHandler(this.Exit_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.FontToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Click += new System.EventHandler(this.FontToolStrip_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(75, 28);
            this.toolStripComboBox2.Click += new System.EventHandler(this.FontToolStrip_Click);
            // 
            // rtbEditor
            // 
            this.rtbEditor.BackColor = System.Drawing.Color.White;
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Location = new System.Drawing.Point(0, 56);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(800, 394);
            this.rtbEditor.TabIndex = 2;
            this.rtbEditor.Text = "";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lab03_02.Properties.Resources._1969648;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "NEW";
            this.toolStripButton2.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.White;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lab03_02.Properties.Resources.images;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "SAVE";
            this.toolStripButton1.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.BackColor = System.Drawing.Color.White;
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = global::Lab03_02.Properties.Resources._110_1108106_bold_italic_underline_icons;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonBold.Text = "B";
            this.toolStripButtonBold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = global::Lab03_02.Properties.Resources.unnamed;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonItalic.Text = "I";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = global::Lab03_02.Properties.Resources._1828096;
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonUnderline.Text = "U";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // TaoVanBanMoiToolStrip
            // 
            this.TaoVanBanMoiToolStrip.Image = global::Lab03_02.Properties.Resources._1969648;
            this.TaoVanBanMoiToolStrip.Name = "TaoVanBanMoiToolStrip";
            this.TaoVanBanMoiToolStrip.Size = new System.Drawing.Size(235, 26);
            this.TaoVanBanMoiToolStrip.Text = "Tạo văn bản mới";
            this.TaoVanBanMoiToolStrip.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // MoTapTinToolStrip
            // 
            this.MoTapTinToolStrip.Image = global::Lab03_02.Properties.Resources._7604005;
            this.MoTapTinToolStrip.Name = "MoTapTinToolStrip";
            this.MoTapTinToolStrip.Size = new System.Drawing.Size(235, 26);
            this.MoTapTinToolStrip.Text = "Mở tập tin";
            this.MoTapTinToolStrip.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trình soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaoVanBanMoiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem MoTapTinToolStrip;
        private System.Windows.Forms.ToolStripMenuItem LuuNoiDungVanBanToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStrip;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
    }
}
