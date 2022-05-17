using System.Diagnostics;

namespace BMP2PNG
{    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string srcPath = string.Empty;
        private string optPath = string.Empty;

        private void scrBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                srcPath = folderDialog.SelectedPath;
                sourceDirTextbox.Text = folderDialog.SelectedPath;
            }
        }

        private void optBtn_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                optPath = folderDialog.SelectedPath;
                sourceDirTextbox.Text = folderDialog.SelectedPath;
            }
        }
    }
}