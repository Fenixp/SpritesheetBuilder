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
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.ofdImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bwLoadFiles = new System.ComponentModel.BackgroundWorker();
            this.tlpMain.SuspendLayout();
            this.flpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.flpTitle, 0, 0);
            this.tlpMain.Controls.Add(this.flpContent, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(731, 560);
            this.tlpMain.TabIndex = 0;
            // 
            // flpTitle
            // 
            this.flpTitle.Controls.Add(this.bttAddImage);
            this.flpTitle.Controls.Add(this.bttDelete);
            this.flpTitle.Controls.Add(this.button1);
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
            // flpContent
            // 
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(3, 43);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(725, 514);
            this.flpContent.TabIndex = 1;
            // 
            // ofdImageDialog
            // 
            this.ofdImageDialog.Multiselect = true;
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
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(312, 3);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(99, 30);
            this.bttSave.TabIndex = 2;
            this.bttSave.Text = "Save spritesheet";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open spritesheet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bwLoadFiles
            // 
            this.bwLoadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadFiles_DoWork);
            this.bwLoadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFiles_RunWorkerCompleted);
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
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bwLoadFiles;
    }
}

