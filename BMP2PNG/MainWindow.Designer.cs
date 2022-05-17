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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceDirTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.fileCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview bmp Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
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
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(4, 106);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(426, 96);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.Text = "";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "BMP2PNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox sourceDirTextbox;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Label label3;
        private Label fileCountLabel;
        private RichTextBox logTextBox;
    }
}