using SpritesheetBuilderBackend.Controllers;
using SpritesheetBuilderBackend.Resources;
using SpritesheetBuilderBackend.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.TestForms;

namespace SpritesheetBuilder
{
    public partial class SpritesheetBuilder : Form
    {
        private static SpritesheetBuilderController _controller = new SpritesheetBuilderController();

        public SpritesheetBuilder()
        {
            InitializeComponent();
        }

        private void SpritesheetBuilder_Load(object sender, EventArgs e)
        {
            string imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
            ofdImageDialog.Filter = string.Format("Images|{0}|All Files|*.*", imageExtensions);
        }

        private void bttAddImage_Click(object sender, EventArgs e)
        {
            if (ofdImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bwLoadFiles.RunWorkerAsync(ofdImageDialog.FileNames);
            }
        }

        private void bwLoadFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _controller.ImageFilesRead((string[])e.Argument);
        }

        private void bwLoadFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ImageFilesReadResult result = (ImageFilesReadResult)e.Result;

            if (!result.HasErrors)
            {
                processImages();
            }
            
            if(result.HasErrors || result.HasWarnings)
            {
                ErrorList errors = new ErrorList();
                errors.Result = result;
                errors.ShowDialog();
            }
        }

        private void processImages()
        {
            flpContent.Controls.Clear();
            foreach (KeyValuePair<string, Image> image in _controller.Images)
            {
                ImageControl icontrol = new ImageControl(_controller);
                icontrol.Image = image.Value;
                icontrol.tbImageName.Text = image.Key;
                flpContent.Controls.Add(icontrol);
            }
        }

        private void bttPickFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderToSave.ShowDialog() == DialogResult.OK && fbdFolderToSave.SelectedPath != String.Empty)
            {
                tbFolderPath.Text = fbdFolderToSave.SelectedPath;
            }
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFileNameValidity(tbFolderPath.Text, tbFileName.Text))
            {
                _controller.SaveSpriteSheet(tbFileName.Text, tbFolderPath.Text);
            }
        }
    }
}
