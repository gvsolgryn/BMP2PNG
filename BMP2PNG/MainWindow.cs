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

        private void ScrBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                SrcPath = folderDialog.SelectedPath;
                sourceDirTextbox.Text = folderDialog.SelectedPath;

                BmpArray = Directory.GetFiles(SrcPath, "*.bmp", SearchOption.TopDirectoryOnly);

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

            foreach (var bmpFile in BmpArray)
            {
                var count = 1;

                var bmp = new Bitmap(bmpFile);

                pictureBox.Image = bmp;

                Update();

                Debug.WriteLine(OptPath + count);
                //bmp.Save((OptPath + "\" + count), ImageFormat.Png);

                Thread.Sleep(1000);

                count++;
            }
        }
    }
}