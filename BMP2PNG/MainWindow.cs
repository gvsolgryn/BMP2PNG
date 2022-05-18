using System.Diagnostics;
using System.Drawing.Imaging;

namespace BMP2PNG
{    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string SrcPath = string.Empty;
        private string OptPath = string.Empty;
        private string[] BmpArray = { };
        private List<string> FileNameList = new List<string>();

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

                this.fileCountLabelRight.Text = BmpArray.Length.ToString();
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
            ConvertBmp2Png();
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

                pictureBox.Image = bmp;

                Update();

                bmp.Save(OptPath + "\\" + FileNameList[index].Replace("bmp", "png"), ImageFormat.Png);

                Thread.Sleep(100);

                index++;
            }
        }
    }
}