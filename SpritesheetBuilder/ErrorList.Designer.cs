namespace SpritesheetBuilder
{
    partial class ErrorList
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
            this.tlpErrorList = new System.Windows.Forms.TableLayoutPanel();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.bttOk = new System.Windows.Forms.Button();
            this.tlpErrorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpErrorList
            // 
            this.tlpErrorList.ColumnCount = 1;
            this.tlpErrorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpErrorList.Controls.Add(this.tbErrors, 0, 0);
            this.tlpErrorList.Controls.Add(this.bttOk, 0, 1);
            this.tlpErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpErrorList.Location = new System.Drawing.Point(0, 0);
            this.tlpErrorList.Name = "tlpErrorList";
            this.tlpErrorList.RowCount = 2;
            this.tlpErrorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpErrorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpErrorList.Size = new System.Drawing.Size(465, 644);
            this.tlpErrorList.TabIndex = 0;
            // 
            // tbErrors
            // 
            this.tbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbErrors.Location = new System.Drawing.Point(3, 3);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbErrors.Size = new System.Drawing.Size(459, 608);
            this.tbErrors.TabIndex = 0;
            // 
            // bttOk
            // 
            this.bttOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttOk.Location = new System.Drawing.Point(387, 617);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 24);
            this.bttOk.TabIndex = 1;
            this.bttOk.Text = "Ok";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // ErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 644);
            this.Controls.Add(this.tlpErrorList);
            this.Name = "ErrorList";
            this.Text = "Read errors";
            this.Load += new System.EventHandler(this.ErrorList_Load);
            this.tlpErrorList.ResumeLayout(false);
            this.tlpErrorList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpErrorList;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.Button bttOk;

    }
}