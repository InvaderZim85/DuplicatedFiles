namespace DuplicatedFiles
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.checkIncludeSubDirs = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceFiles = new System.Windows.Forms.BindingSource(this.components);
            this.infoProgressBar = new DuplicatedFiles.InfoProgressBar();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxFiles.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.checkIncludeSubDirs);
            this.groupBoxData.Controls.Add(this.btnLoad);
            this.groupBoxData.Controls.Add(this.lblDirectory);
            this.groupBoxData.Controls.Add(this.btnBrowse);
            this.groupBoxData.Controls.Add(this.txtDirectory);
            this.groupBoxData.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(732, 98);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Daten";
            // 
            // checkIncludeSubDirs
            // 
            this.checkIncludeSubDirs.AutoSize = true;
            this.checkIncludeSubDirs.Location = new System.Drawing.Point(60, 45);
            this.checkIncludeSubDirs.Name = "checkIncludeSubDirs";
            this.checkIncludeSubDirs.Size = new System.Drawing.Size(142, 17);
            this.checkIncludeSubDirs.TabIndex = 7;
            this.checkIncludeSubDirs.Text = "Unterordner einbeziehen";
            this.checkIncludeSubDirs.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(60, 68);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(12, 22);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(42, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Ordner:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(682, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(60, 19);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(616, 20);
            this.txtDirectory.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sourceFiles;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(726, 345);
            this.dataGridView.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(654, 32);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Anzeigen";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.dataGridView);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(0, 98);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(732, 364);
            this.groupBoxFiles.TabIndex = 6;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Dateien";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblInfo);
            this.panelBottom.Controls.Add(this.infoProgressBar);
            this.panelBottom.Controls.Add(this.btnDisplay);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 462);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(732, 63);
            this.panelBottom.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 6;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Datei";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "Filepath";
            this.filepathDataGridViewTextBoxColumn.FillWeight = 5.076141F;
            this.filepathDataGridViewTextBoxColumn.HeaderText = "Pfad";
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            this.filepathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceFiles
            // 
            this.sourceFiles.DataSource = typeof(DuplicatedFiles.DataObjects.FileModel);
            // 
            // infoProgressBar
            // 
            this.infoProgressBar.CustomText = null;
            this.infoProgressBar.DisplayStyle = DuplicatedFiles.ProgressBarDisplayText.Percentage;
            this.infoProgressBar.Location = new System.Drawing.Point(3, 3);
            this.infoProgressBar.Name = "infoProgressBar";
            this.infoProgressBar.Size = new System.Drawing.Size(726, 23);
            this.infoProgressBar.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 525);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.groupBoxData);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doppelte Dateien";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxFiles.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.CheckBox checkIncludeSubDirs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource sourceFiles;
        private InfoProgressBar infoProgressBar;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblInfo;
    }
}

