using SpritesheetBuilderBackend.Resources;
using SpritesheetBuilderBackend.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpritesheetBuilder
{
    public partial class ErrorList : Form
    {
        public ImageFilesReadResult Result { get; set; }

        public ErrorList()
        {
            InitializeComponent();
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {
            tbErrors.Text += SpritesheetBuilderRX.ProblesmWhileReading + Environment.NewLine;
            if (Result.HasErrors)
            {
                tbErrors.Text += SpritesheetBuilderRX.Errors + Environment.NewLine;

                foreach (string error in Result.Errors)
                {
                    tbErrors.Text += error + Environment.NewLine;
                }
            }

            if (Result.HasWarnings)
            {
                tbErrors.Text += SpritesheetBuilderRX.Warnings + Environment.NewLine;

                foreach (string warning in Result.Warnings)
                {
                    tbErrors.Text += warning + Environment.NewLine;
                }
            }
        }
    }
}
