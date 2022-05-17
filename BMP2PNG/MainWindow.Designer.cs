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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srcBtn = new System.Windows.Forms.Button();
            this.sourceDirTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.convertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.srcBtn);
            this.groupBox1.Controls.Add(this.sourceDirTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.optBtn.Click += new System.EventHandler(this.optBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(129, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(602, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
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
            this.srcBtn.Click += new System.EventHandler(this.scrBtn_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
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
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelBtn);
            this.groupBox3.Controls.Add(this.convertBtn);
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Controls.Add(this.logTextBox);
            this.groupBox3.Controls.Add(this.fileCountLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(350, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.AutoSize = true;
            this.fileCountLabel.Location = new System.Drawing.Point(78, 24);
            this.fileCountLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(26, 15);
            this.fileCountLabel.TabIndex = 1;
            this.fileCountLabel.Text = "0/0";
            this.fileCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 149);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(424, 23);
            this.progressBar.TabIndex = 4;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(276, 179);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 5;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(357, 179);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "BMP2PNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button optBtn;
        private TextBox textBox2;
        private Label label2;
        private Button srcBtn;
        private TextBox sourceDirTextbox;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox;
        private GroupBox groupBox3;
        private Label label3;
        private Label fileCountLabel;
        private ProgressBar progressBar;
        private RichTextBox logTextBox;
        private Button cancelBtn;
        private Button convertBtn;
    }
}