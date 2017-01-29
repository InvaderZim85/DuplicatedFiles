using System;
using System.IO;
using System.Windows.Forms;
using DuplicatedFiles.Global;

namespace DuplicatedFiles
{
    public partial class FileInfoControl : UserControl
    {
        /// <summary>
        /// Creates a new instance of the control
        /// </summary>
        public FileInfoControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Shows the infos of a file
        /// </summary>
        /// <param name="file">The file</param>
        public void ShowFileInfo(FileInfo file)
        {
            lblNameData.Text = file.Name;
            lblSizeData.Text = $"{file.Length / 1024:N} KB";
            lblDateData.Text = file.LastWriteTime.ToString("g");
            lblPathData.Text = file.FullName;
        }
        /// <summary>
        /// Occurs when the user hits a menu item in the context menu
        /// </summary>
        private void contextMenu_Click(object sender, EventArgs e)
        {
            Helper.OpenExecute(lblPathData.Text, sender == contextMenuOpen);
        }
    }
}
