using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuplicatedFiles.DataObjects;

namespace DuplicatedFiles
{
    public partial class FormComparsion : Form
    {
        /// <summary>
        /// Contains the list with the files
        /// </summary>
        private readonly List<FileModel> _fileList;

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        /// <param name="fileList">The file list with the files</param>
        public FormComparsion(List<FileModel> fileList)
        {
            InitializeComponent();
            _fileList = fileList;
        }
        /// <summary>
        /// Inits the form
        /// </summary>
        private void InitFileList()
        {
            fileList.Items.Clear();

            var grouped =
                _fileList.OrderByDescending(o => o.FileInfo.CreationTime)
                    .GroupBy(g => g.Md5Hash)
                    .Select(s => s.First())
                    .ToList();

            foreach (var entry in grouped.OrderBy(o => o.FileName))
            {
                fileList.Items.Add(entry);
            }

            fileList.SelectedItem = grouped.OrderBy(o => o.FileName).First();
        }
        /// <summary>
        /// Inits the list with the duplicated entries
        /// </summary>
        /// <param name="file">The selected files</param>
        private void InitCheckedFileList(FileModel file)
        {
            pictureRight.Image = Properties.Resources.photo_icon_23;
            checkedListBoxDelete.Items.Clear();
            FileModel firstEntry = null;
            foreach (var entry in _fileList.Where(w => w.Md5Hash == file.Md5Hash).OrderBy(o => o.FileName))
            {
                // Jump of the "original" file
                if (entry.Filepath == file.Filepath)
                    continue;

                checkedListBoxDelete.Items.Add(entry);
                if (firstEntry == null)
                    firstEntry = entry;
            }

            if (firstEntry != null)
                checkedListBoxDelete.SelectedItem = firstEntry;
        }
        /// <summary>
        /// Occurs when the user selects an entry
        /// </summary>
        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entry = fileList.SelectedItem as FileModel;
            if (entry != null)
            {
                pictureLeft.ImageLocation = entry.Filepath;
                InitCheckedFileList(entry);
                fileInfoControlLeft.ShowFileInfo(entry.FileInfo);
            }
        }
        /// <summary>
        /// Occurs when the user selects an entry
        /// </summary>
        private void checkedListBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entry = checkedListBoxDelete.SelectedItem as FileModel;
            if (entry != null)
            {
                pictureRight.ImageLocation = entry.Filepath;
                fileInfoControlRight.ShowFileInfo(entry.FileInfo);
            }
        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void FormComparsion_Load(object sender, EventArgs e)
        {
            InitFileList();
        }
    }
}
