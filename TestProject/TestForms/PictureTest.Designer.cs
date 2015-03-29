namespace TestProject.TestForms
{
    partial class PictureTest
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
            this.pbResultPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResultPicture
            // 
            this.pbResultPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResultPicture.Location = new System.Drawing.Point(0, 0);
            this.pbResultPicture.Name = "pbResultPicture";
            this.pbResultPicture.Size = new System.Drawing.Size(481, 423);
            this.pbResultPicture.TabIndex = 0;
            this.pbResultPicture.TabStop = false;
            // 
            // PictureTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 423);
            this.Controls.Add(this.pbResultPicture);
            this.Name = "PictureTest";
            this.Text = "PictureTest";
            ((System.ComponentModel.ISupportInitialize)(this.pbResultPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbResultPicture;

    }
}