namespace SpritesheetBuilder
{
    partial class ImageControl
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
            this.tlpImageControls = new System.Windows.Forms.TableLayoutPanel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbImageName = new System.Windows.Forms.TextBox();
            this.tlpImageControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpImageControls
            // 
            this.tlpImageControls.ColumnCount = 1;
            this.tlpImageControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageControls.Controls.Add(this.pbImage, 0, 0);
            this.tlpImageControls.Controls.Add(this.tbImageName, 0, 1);
            this.tlpImageControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImageControls.Location = new System.Drawing.Point(0, 0);
            this.tlpImageControls.Name = "tlpImageControls";
            this.tlpImageControls.RowCount = 2;
            this.tlpImageControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpImageControls.Size = new System.Drawing.Size(100, 100);
            this.tlpImageControls.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(94, 64);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // tbImageName
            // 
            this.tbImageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImageName.Location = new System.Drawing.Point(3, 73);
            this.tbImageName.Name = "tbImageName";
            this.tbImageName.Size = new System.Drawing.Size(94, 20);
            this.tbImageName.TabIndex = 1;
            this.tbImageName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImageName_KeyPress);
            this.tbImageName.Leave += new System.EventHandler(this.tbImageName_Leave);
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpImageControls);
            this.Name = "ImageControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.ImageControl_Load);
            this.tlpImageControls.ResumeLayout(false);
            this.tlpImageControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpImageControls;
        private System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.TextBox tbImageName;

    }
}
