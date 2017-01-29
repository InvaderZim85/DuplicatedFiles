using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuplicatedFiles.Business;
using DuplicatedFiles.DataObjects;

namespace DuplicatedFiles
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Contains the file manager
        /// </summary>
        private readonly FileManager _fileManager = new FileManager();
        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            _fileManager.InfoEvent += _fileManager_InfoEvent;
        }
        /// <summary>
        /// Loads the files and shows them
        /// </summary>
        private void LoadFiles()
        {
            if (string.IsNullOrEmpty(txtDirectory.Text))
                return;

            groupBoxData.Enabled = false;
            btnLoad.Enabled = false;
            Task.Factory.StartNew(() =>
            {
                var loadTask =
                    Task.Factory.StartNew(
                        () =>
                            _fileManager.GetDuplicatedFileList(txtDirectory.Text, checkIncludeSubDirs.Checked));

                return loadTask.Result;
            }).ContinueWith(t =>
            {
                if (t.Exception == null)
                {
                    SetSource(t.Result);
                }
                else
                {
                    MessageBox.Show($"Beim Laden der Dateien ist ein Fehler aufgetreten:\r\n{t.Exception.Message}",
                        "Laden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnLoad.Enabled = true;
                groupBoxData.Enabled = true;
                btnDisplay.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        /// <summary>
        /// Sets the data source
        /// </summary>
        /// <param name="source">The source</param>
        private void SetSource(List<FileModel> source)
        {
            sourceFiles.DataSource = null;
            sourceFiles.DataSource = source.OrderBy(o => o.Md5Hash).ToList();
        }
        /// <summary>
        /// Occurs when the user hits the browse button
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog {Description = "Wähle den gewünschten Ordner aus"};
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = dialog.SelectedPath;
            }
        }
        /// <summary>
        /// Occurs when the user hits the load button
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }
        /// <summary>
        /// Occurs when the info event of the filemanager was fired
        /// </summary>
        /// <param name="max">The max count</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        private void _fileManager_InfoEvent(int max, int step, string msg)
        {
            Invoke((MethodInvoker) delegate
            {
                if (max != 0)
                {
                    infoProgressBar.Minimum = 0;
                    infoProgressBar.Maximum = max;
                    infoProgressBar.Value = step;

                    lblInfo.Text = $"{step}/{max}: {msg}";
                }
                else
                {
                    infoProgressBar.Value = 0;
                    infoProgressBar.CustomText = msg;
                }
            });
            
        }
        /// <summary>
        /// Occurs when the user hits the show button
        /// </summary>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var list = sourceFiles.DataSource as List<FileModel>;
            if (list != null)
            {
                var form = new FormComparsion(list);
                form.ShowDialog();
            }
        }
    }
}
