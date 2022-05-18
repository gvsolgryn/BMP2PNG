namespace BMP2PNG
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optBtn = new System.Windows.Forms.Button();
            this.outputDirTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srcBtn = new System.Windows.Forms.Button();
            this.sourceDirTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileCountLabelRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.fileCountLabelLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bMP2PNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYUV422ToPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYUV422ToPNGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optBtn);
            this.groupBox1.Controls.Add(this.outputDirTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.srcBtn);
            this.groupBox1.Controls.Add(this.sourceDirTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(776, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bmp Path";
            // 
            // optBtn
            // 
            this.optBtn.Location = new System.Drawing.Point(737, 73);
            this.optBtn.Name = "optBtn";
            this.optBtn.Size = new System.Drawing.Size(31, 23);
            this.optBtn.TabIndex = 5;
            this.optBtn.Text = "...";
            this.optBtn.UseVisualStyleBackColor = true;
            this.optBtn.Click += new System.EventHandler(this.OptBtn_Click);
            // 
            // outputDirTextbox
            // 
            this.outputDirTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDirTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.outputDirTextbox.Enabled = false;
            this.outputDirTextbox.Location = new System.Drawing.Point(129, 72);
            this.outputDirTextbox.Name = "outputDirTextbox";
            this.outputDirTextbox.ReadOnly = true;
            this.outputDirTextbox.Size = new System.Drawing.Size(602, 23);
            this.outputDirTextbox.TabIndex = 4;
            this.outputDirTextbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(737, 30);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(31, 23);
            this.srcBtn.TabIndex = 2;
            this.srcBtn.Text = "...";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.ScrBtn_Click);
            // 
            // sourceDirTextbox
            // 
            this.sourceDirTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceDirTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.sourceDirTextbox.Enabled = false;
            this.sourceDirTextbox.Location = new System.Drawing.Point(129, 29);
            this.sourceDirTextbox.Name = "sourceDirTextbox";
            this.sourceDirTextbox.ReadOnly = true;
            this.sourceDirTextbox.Size = new System.Drawing.Size(602, 23);
            this.sourceDirTextbox.TabIndex = 1;
            this.sourceDirTextbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview bmp Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileCountLabelRight);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.convertBtn);
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Controls.Add(this.logTextBox);
            this.groupBox3.Controls.Add(this.fileCountLabelLeft);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(350, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // fileCountLabelRight
            // 
            this.fileCountLabelRight.AutoSize = true;
            this.fileCountLabelRight.Location = new System.Drawing.Point(110, 24);
            this.fileCountLabelRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileCountLabelRight.Name = "fileCountLabelRight";
            this.fileCountLabelRight.Size = new System.Drawing.Size(14, 15);
            this.fileCountLabelRight.TabIndex = 8;
            this.fileCountLabelRight.Text = "0";
            this.fileCountLabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(355, 179);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 5;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 150);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(424, 23);
            this.progressBar.TabIndex = 4;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(6, 47);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(426, 96);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.Text = "";
            // 
            // fileCountLabelLeft
            // 
            this.fileCountLabelLeft.AutoSize = true;
            this.fileCountLabelLeft.Location = new System.Drawing.Point(78, 24);
            this.fileCountLabelLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileCountLabelLeft.Name = "fileCountLabelLeft";
            this.fileCountLabelLeft.Size = new System.Drawing.Size(14, 15);
            this.fileCountLabelLeft.TabIndex = 1;
            this.fileCountLabelLeft.Text = "0";
            this.fileCountLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "bmp Files :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMP2PNGToolStripMenuItem,
            this.utilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bMP2PNGToolStripMenuItem
            // 
            this.bMP2PNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램종료ToolStripMenuItem});
            this.bMP2PNGToolStripMenuItem.Name = "bMP2PNGToolStripMenuItem";
            this.bMP2PNGToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bMP2PNGToolStripMenuItem.Text = "BMP2PNG";
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uYUV422ToPNGToolStripMenuItem});
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.utilToolStripMenuItem.Text = "Util";
            // 
            // uYUV422ToPNGToolStripMenuItem
            // 
            this.uYUV422ToPNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uYUV422ToPNGToolStripMenuItem1});
            this.uYUV422ToPNGToolStripMenuItem.Name = "uYUV422ToPNGToolStripMenuItem";
            this.uYUV422ToPNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uYUV422ToPNGToolStripMenuItem.Text = "YUV to PNG";
            // 
            // uYUV422ToPNGToolStripMenuItem1
            // 
            this.uYUV422ToPNGToolStripMenuItem1.Name = "uYUV422ToPNGToolStripMenuItem1";
            this.uYUV422ToPNGToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.uYUV422ToPNGToolStripMenuItem1.Text = "UYUV4:2:2 to PNG";
            this.uYUV422ToPNGToolStripMenuItem1.Click += new System.EventHandler(this.uYUV422ToPNGToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "BMP2PNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button optBtn;
        private TextBox outputDirTextbox;
        private Label label2;
        private Button srcBtn;
        private TextBox sourceDirTextbox;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox;
        private GroupBox groupBox3;
        private Label label3;
        private Label fileCountLabelLeft;
        private ProgressBar progressBar;
        private RichTextBox logTextBox;
        private Button convertBtn;
        private Label fileCountLabelRight;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bMP2PNGToolStripMenuItem;
        private ToolStripMenuItem utilToolStripMenuItem;
        private ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private ToolStripMenuItem uYUV422ToPNGToolStripMenuItem;
        private ToolStripMenuItem uYUV422ToPNGToolStripMenuItem1;
    }
}