namespace DuplicatedFiles
{
    partial class FileInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblPathData = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblSizeData = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblNameData = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.tableLayoutPanel);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(373, 100);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblPathData, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblDateData, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblSizeData, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblSize, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblDate, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblPath, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblNameData, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(367, 81);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblPathData
            // 
            this.lblPathData.AutoSize = true;
            this.lblPathData.ContextMenuStrip = this.contextMenu;
            this.lblPathData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPathData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPathData.Location = new System.Drawing.Point(103, 60);
            this.lblPathData.Name = "lblPathData";
            this.lblPathData.Size = new System.Drawing.Size(261, 20);
            this.lblPathData.TabIndex = 7;
            this.lblPathData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuOpen,
            this.contextMenuShow});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(168, 48);
            // 
            // contextMenuOpen
            // 
            this.contextMenuOpen.Name = "contextMenuOpen";
            this.contextMenuOpen.Size = new System.Drawing.Size(167, 22);
            this.contextMenuOpen.Text = "Öffnen";
            this.contextMenuOpen.Click += new System.EventHandler(this.contextMenu_Click);
            // 
            // contextMenuShow
            // 
            this.contextMenuShow.Name = "contextMenuShow";
            this.contextMenuShow.Size = new System.Drawing.Size(167, 22);
            this.contextMenuShow.Text = "In Ordner zeigen..";
            this.contextMenuShow.Click += new System.EventHandler(this.contextMenu_Click);
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateData.Location = new System.Drawing.Point(103, 40);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(261, 20);
            this.lblDateData.TabIndex = 6;
            this.lblDateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSizeData
            // 
            this.lblSizeData.AutoSize = true;
            this.lblSizeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSizeData.Location = new System.Drawing.Point(103, 20);
            this.lblSizeData.Name = "lblSizeData";
            this.lblSizeData.Size = new System.Drawing.Size(261, 20);
            this.lblSizeData.TabIndex = 5;
            this.lblSizeData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Datei:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.Location = new System.Drawing.Point(3, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(94, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Größe:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(3, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Änderungsdatum:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(3, 60);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(94, 20);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Pfad:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameData
            // 
            this.lblNameData.AutoSize = true;
            this.lblNameData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameData.Location = new System.Drawing.Point(103, 0);
            this.lblNameData.Name = "lblNameData";
            this.lblNameData.Size = new System.Drawing.Size(261, 20);
            this.lblNameData.TabIndex = 4;
            this.lblNameData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "FileInfoControl";
            this.Size = new System.Drawing.Size(373, 100);
            this.groupBoxInfo.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblPathData;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblSizeData;
        private System.Windows.Forms.Label lblNameData;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShow;
    }
}
