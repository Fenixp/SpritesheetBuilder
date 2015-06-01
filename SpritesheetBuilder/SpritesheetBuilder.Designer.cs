namespace SpritesheetBuilder
{
    partial class SpritesheetBuilder
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.bttAddImage = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttOpenSpritesheet = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSavePath = new System.Windows.Forms.FlowLayoutPanel();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.bttPickFolder = new System.Windows.Forms.Button();
            this.ofdImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.bwLoadFiles = new System.ComponentModel.BackgroundWorker();
            this.fbdFolderToSave = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdOpenSpritesheet = new System.Windows.Forms.OpenFileDialog();
            this.bwLoadSpritesheet = new System.ComponentModel.BackgroundWorker();
            this.tlpMain.SuspendLayout();
            this.flpTitle.SuspendLayout();
            this.flpSavePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.flpTitle, 0, 0);
            this.tlpMain.Controls.Add(this.flpContent, 0, 1);
            this.tlpMain.Controls.Add(this.flpSavePath, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.Size = new System.Drawing.Size(731, 560);
            this.tlpMain.TabIndex = 0;
            // 
            // flpTitle
            // 
            this.flpTitle.Controls.Add(this.bttAddImage);
            this.flpTitle.Controls.Add(this.bttDelete);
            this.flpTitle.Controls.Add(this.bttOpenSpritesheet);
            this.flpTitle.Controls.Add(this.bttSave);
            this.flpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTitle.Location = new System.Drawing.Point(3, 3);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(725, 34);
            this.flpTitle.TabIndex = 0;
            // 
            // bttAddImage
            // 
            this.bttAddImage.Location = new System.Drawing.Point(3, 3);
            this.bttAddImage.Name = "bttAddImage";
            this.bttAddImage.Size = new System.Drawing.Size(87, 30);
            this.bttAddImage.TabIndex = 0;
            this.bttAddImage.Text = "Add Images...";
            this.bttAddImage.UseVisualStyleBackColor = true;
            this.bttAddImage.Click += new System.EventHandler(this.bttAddImage_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(96, 3);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(100, 30);
            this.bttDelete.TabIndex = 1;
            this.bttDelete.Text = "Delete selected";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttOpenSpritesheet
            // 
            this.bttOpenSpritesheet.Location = new System.Drawing.Point(202, 3);
            this.bttOpenSpritesheet.Name = "bttOpenSpritesheet";
            this.bttOpenSpritesheet.Size = new System.Drawing.Size(104, 30);
            this.bttOpenSpritesheet.TabIndex = 3;
            this.bttOpenSpritesheet.Text = "Open spritesheet";
            this.bttOpenSpritesheet.UseVisualStyleBackColor = true;
            this.bttOpenSpritesheet.Click += new System.EventHandler(this.bttOpenSpritesheet_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(312, 3);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(99, 30);
            this.bttSave.TabIndex = 2;
            this.bttSave.Text = "Save spritesheet";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(3, 43);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(725, 474);
            this.flpContent.TabIndex = 1;
            // 
            // flpSavePath
            // 
            this.flpSavePath.Controls.Add(this.tbFolderPath);
            this.flpSavePath.Controls.Add(this.tbFileName);
            this.flpSavePath.Controls.Add(this.bttPickFolder);
            this.flpSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSavePath.Location = new System.Drawing.Point(3, 523);
            this.flpSavePath.Name = "flpSavePath";
            this.flpSavePath.Size = new System.Drawing.Size(725, 34);
            this.flpSavePath.TabIndex = 2;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Enabled = false;
            this.tbFolderPath.Location = new System.Drawing.Point(3, 3);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(563, 20);
            this.tbFolderPath.TabIndex = 0;
            this.tbFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(572, 3);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(100, 20);
            this.tbFileName.TabIndex = 1;
            // 
            // bttPickFolder
            // 
            this.bttPickFolder.Location = new System.Drawing.Point(678, 3);
            this.bttPickFolder.Name = "bttPickFolder";
            this.bttPickFolder.Size = new System.Drawing.Size(31, 23);
            this.bttPickFolder.TabIndex = 2;
            this.bttPickFolder.Text = "...";
            this.bttPickFolder.UseVisualStyleBackColor = true;
            this.bttPickFolder.Click += new System.EventHandler(this.bttPickFolder_Click);
            // 
            // ofdImageDialog
            // 
            this.ofdImageDialog.Multiselect = true;
            // 
            // bwLoadFiles
            // 
            this.bwLoadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadFiles_DoWork);
            this.bwLoadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFiles_RunWorkerCompleted);
            // 
            // ofdOpenSpritesheet
            // 
            this.ofdOpenSpritesheet.Filter = "Spritesheet Files | *.txt";
            // 
            // bwLoadSpritesheet
            // 
            this.bwLoadSpritesheet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadSpritesheet_DoWork);
            this.bwLoadSpritesheet.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFiles_RunWorkerCompleted);
            // 
            // SpritesheetBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 560);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(747, 599);
            this.Name = "SpritesheetBuilder";
            this.Text = "Spritesheet builder";
            this.Load += new System.EventHandler(this.SpritesheetBuilder_Load);
            this.tlpMain.ResumeLayout(false);
            this.flpTitle.ResumeLayout(false);
            this.flpSavePath.ResumeLayout(false);
            this.flpSavePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpTitle;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.OpenFileDialog ofdImageDialog;
        private System.Windows.Forms.Button bttAddImage;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttOpenSpritesheet;
        private System.ComponentModel.BackgroundWorker bwLoadFiles;
        private System.Windows.Forms.FlowLayoutPanel flpSavePath;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button bttPickFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderToSave;
        private System.Windows.Forms.OpenFileDialog ofdOpenSpritesheet;
        private System.ComponentModel.BackgroundWorker bwLoadSpritesheet;
    }
}

