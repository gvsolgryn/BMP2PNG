using System.Diagnostics;
using System.Drawing.Imaging;

namespace BMP2PNG
{    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.progressBar.Step = 1;
        }

        private string SrcPath = string.Empty;
        private string OptPath = string.Empty;
        private string[] BmpArray = { };
        private List<string> FileNameList = new List<string>();

        Thread t1;

        private void ScrBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            BmpArray = Array.Empty<string>();
            FileNameList.Clear();

            if (dialogResult == DialogResult.OK)
            {
                SrcPath = folderDialog.SelectedPath;
                sourceDirTextbox.Text = folderDialog.SelectedPath;

                BmpArray = Directory.GetFiles(SrcPath, "*.bmp", SearchOption.TopDirectoryOnly);
                var directoryInfo = new DirectoryInfo(SrcPath);
                
                foreach (var file in directoryInfo.GetFiles("*.bmp"))
                {
                    FileNameList.Add(file.Name);
                }

                fileCountLabelRight.Text = BmpArray.Length.ToString();
                progressBar.Maximum = BmpArray.Length;
            }
        }

        private void OptBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                OptPath = folderDialog.SelectedPath;
                outputDirTextbox.Text = folderDialog.SelectedPath;
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(ConvertBmp2Png));
            t1.Start();
        }

        private void ConvertBmp2Png()
        {
            int index = 0;

            if (string.IsNullOrEmpty(SrcPath))
            {
                MessageBox.Show("bmp 폴더를 선택해주십시오.");

                return;
            }

            if (string.IsNullOrEmpty(OptPath))
            {
                MessageBox.Show("png 저장용 폴더를 선택해주십시오.");

                return;
            }

            if (SrcPath == OptPath)
            {
                var result = MessageBox.Show("bmp 폴더와 변환 폴더가 같습니다. 계속 하시겠습니까?", "주의!", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            foreach (var bmpFileDir in BmpArray)
            {
                var bmp = new Bitmap(bmpFileDir);

                if (pictureBox.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        pictureBox.Image = bmp;
                        bmp.Save(OptPath + "\\" + FileNameList[index].Replace("bmp", "png"), ImageFormat.Png);
                    });
                }
                else
                {
                    pictureBox.Image = bmp;
                    bmp.Save(OptPath + "\\" + FileNameList[index].Replace("bmp", "png"), ImageFormat.Png);
                }

                Thread.Sleep(100);

                LogAppend($"{index + 1}번째 파일 변환 완료\n");

                index++;

                if (fileCountLabelLeft.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        fileCountLabelLeft.Text = index.ToString();
                    });
                }
                else
                {
                    fileCountLabelLeft.Text = index.ToString();
                }

                if (progressBar.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        progressBar.PerformStep();
                    });
                }
            }
        }

        private void LogAppend(string txt)
        {
            if (logTextBox.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    logTextBox.AppendText(txt);
                    logTextBox.ScrollToCaret();
                });
            }
            else
            {
                logTextBox.AppendText(txt);
                logTextBox.ScrollToCaret();
            }
        }

        private void uYUV422ToPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uyuv422ToPngForm = new UYUV422toPNG();
            uyuv422ToPngForm.ShowDialog();
        }
    }
}