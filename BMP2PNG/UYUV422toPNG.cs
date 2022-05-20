using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP2PNG
{
    public partial class UYUV422toPNG : Form
    {
        public UYUV422toPNG()
        {
            InitializeComponent();

            this.progressBar.Step = 1;
        }

        private string SrcPath = string.Empty;
        private string OptPath = string.Empty;
        private string FFmpegPath = string.Empty;
        private string[] UYUV422PathArray = { };
        private List<string> UYUV422FileNameList = new List<string>();

        private ProcessStartInfo _processStartInfo = new ProcessStartInfo();
        private Process _process = new Process();

        private void ScrBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            UYUV422PathArray = Array.Empty<string>();
            UYUV422FileNameList.Clear();

            if (dialogResult == DialogResult.OK)
            {
                SrcPath = folderDialog.SelectedPath;
                sourceDirTextbox.Text = folderDialog.SelectedPath;

                UYUV422PathArray = Directory.GetFiles(SrcPath, "*.yuv", SearchOption.TopDirectoryOnly);
                var directoryInfo = new DirectoryInfo(SrcPath);

                foreach (var file in directoryInfo.GetFiles("*.yuv"))
                {
                    UYUV422FileNameList.Add(file.Name);
                }

                fileCountLabelRight.Text = UYUV422PathArray.Length.ToString();
                progressBar.Maximum = UYUV422PathArray.Length;

                if (UYUV422PathArray.Length < 1)
                {
                    MessageBox.Show("폴더 안에 YUV 파일이 없습니다. YUV 파일이 있는 폴더를 선택하십시오.");
                }
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

        private void FFmpegSelectBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            var dialogResult = fileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                MessageBox.Show("ffmpeg를 이용하여 변환하기 때문에 ffmpeg.exe 파일이 필요합니다!", "주의!");
                return;
            }

            FFmpegPath = fileDialog.FileName;
            ffmpegSelectTextbox.Text = fileDialog.FileName;
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
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

            if (string.IsNullOrEmpty(FFmpegPath))
            {
                MessageBox.Show("ffmpeg 파일을 선택해주십시오.");

                return;
            }

            if (SrcPath == OptPath)
            {
                var result = MessageBox.Show("yuv 폴더와 변환 폴더가 같습니다. 계속 하시겠습니까?", "주의!", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var thread = new Thread(new ThreadStart(Convert));

            thread.Start();
        }

        private void Convert()
        {
            var index = 0;

            foreach (var yuvDir in UYUV422PathArray)
            {
                var optFilePath = OptPath + "\\" + UYUV422FileNameList[index].Replace("yuv", "png");

                Debug.WriteLine($"srcPath = {yuvDir}");

                Debug.WriteLine($"optPath = {optFilePath}");

                FFmpeg_Run(yuvDir, optFilePath);

                var png = new Bitmap(optFilePath);

                if (pictureBox.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        pictureBox.Image = png;
                    });
                }
                else
                {
                    pictureBox.Image = png;
                }

                index++;

                LogAppendText($"{index}번째 파일 변환 완료\n");

                Thread.Sleep(100);

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

        private void FFmpeg_Run(string inputPath, string outputPath)
        {
            _processStartInfo = new ProcessStartInfo(FFmpegPath);
            _processStartInfo.CreateNoWindow = true;
            _processStartInfo.UseShellExecute = false;
            _processStartInfo.RedirectStandardInput = true;
            _processStartInfo.RedirectStandardOutput = true;
            _processStartInfo.RedirectStandardError = true;

            _processStartInfo.ArgumentList.Add("-y");
            _processStartInfo.ArgumentList.Add("-s");
            _processStartInfo.ArgumentList.Add("1280x720");
            _processStartInfo.ArgumentList.Add("-pix_fmt");
            _processStartInfo.ArgumentList.Add("uyvy422");
            _processStartInfo.ArgumentList.Add("-i");
            _processStartInfo.ArgumentList.Add(inputPath);
            _processStartInfo.ArgumentList.Add(outputPath);

            try
            {
                _process = new Process();
                _process.StartInfo = _processStartInfo;
                _process.Start();
            }
            catch (Exception ex)
            {
                _process.Close();
                MessageBox.Show($"ffmpeg Error : {ex}", "에러");
            }
            _process.Close();
        }

        private void LogAppendText(string txt)
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
    }
}
