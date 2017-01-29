namespace DuplicatedFiles
{
    partial class FormComparsion
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.checkedListBoxDelete = new System.Windows.Forms.CheckedListBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnMarkEntries = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fileInfoControlLeft = new DuplicatedFiles.FileInfoControl();
            this.fileInfoControlRight = new DuplicatedFiles.FileInfoControl();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pictureRight, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.checkedListBoxDelete, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.fileList, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureLeft, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelButtons, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.fileInfoControlLeft, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.fileInfoControlRight, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(864, 561);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureRight
            // 
            this.pictureRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureRight.Image = global::DuplicatedFiles.Properties.Resources.photo_icon_23;
            this.pictureRight.Location = new System.Drawing.Point(435, 3);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(426, 209);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRight.TabIndex = 3;
            this.pictureRight.TabStop = false;
            // 
            // checkedListBoxDelete
            // 
            this.checkedListBoxDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxDelete.FormattingEnabled = true;
            this.checkedListBoxDelete.Location = new System.Drawing.Point(435, 318);
            this.checkedListBoxDelete.Name = "checkedListBoxDelete";
            this.checkedListBoxDelete.Size = new System.Drawing.Size(426, 209);
            this.checkedListBoxDelete.TabIndex = 0;
            this.checkedListBoxDelete.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDelete_SelectedIndexChanged);
            // 
            // fileList
            // 
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(3, 318);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(426, 209);
            this.fileList.TabIndex = 1;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // pictureLeft
            // 
            this.pictureLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLeft.Image = global::DuplicatedFiles.Properties.Resources.photo_icon_23;
            this.pictureLeft.Location = new System.Drawing.Point(3, 3);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(426, 209);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLeft.TabIndex = 2;
            this.pictureLeft.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnMarkEntries);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(432, 530);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(432, 31);
            this.panelButtons.TabIndex = 4;
            // 
            // btnMarkEntries
            // 
            this.btnMarkEntries.Location = new System.Drawing.Point(3, 3);
            this.btnMarkEntries.Name = "btnMarkEntries";
            this.btnMarkEntries.Size = new System.Drawing.Size(139, 23);
            this.btnMarkEntries.TabIndex = 1;
            this.btnMarkEntries.Text = "Alle markieren";
            this.btnMarkEntries.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(354, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // fileInfoControlLeft
            // 
            this.fileInfoControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoControlLeft.Location = new System.Drawing.Point(0, 215);
            this.fileInfoControlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoControlLeft.Name = "fileInfoControlLeft";
            this.fileInfoControlLeft.Size = new System.Drawing.Size(432, 100);
            this.fileInfoControlLeft.TabIndex = 5;
            // 
            // fileInfoControlRight
            // 
            this.fileInfoControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoControlRight.Location = new System.Drawing.Point(432, 215);
            this.fileInfoControlRight.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoControlRight.Name = "fileInfoControlRight";
            this.fileInfoControlRight.Size = new System.Drawing.Size(432, 100);
            this.fileInfoControlRight.TabIndex = 6;
            // 
            // FormComparsion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FormComparsion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplikate";
            this.Load += new System.EventHandler(this.FormComparsion_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.CheckedListBox checkedListBoxDelete;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkEntries;
        private FileInfoControl fileInfoControlLeft;
        private FileInfoControl fileInfoControlRight;
    }
}