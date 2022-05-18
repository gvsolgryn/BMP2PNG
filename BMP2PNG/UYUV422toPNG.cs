using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private string SrcPath = string.Empty;
        private string OptPath = string.Empty;
        private string[] UYUV422PathArray = { };
        private List<string> UYUV422FileNameList = new List<string>();

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
    }
}
