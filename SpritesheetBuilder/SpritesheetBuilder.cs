﻿using SpritesheetBuilderBackend.Controllers;
using SpritesheetBuilderBackend.Resources;
using SpritesheetBuilderBackend.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private void bwLoadSpritesheet_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _controller.ReadSpritesheetFile(tbFolderPath.Text, tbFileName.Text);
        }

        private void bttOpenSpritesheet_Click(object sender, EventArgs e)
        {
            if (ofdOpenSpritesheet.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFolderPath.Text = fbdFolderToSave.SelectedPath = Path.GetDirectoryName(ofdOpenSpritesheet.FileName);
                tbFileName.Text = Path.GetFileNameWithoutExtension(ofdOpenSpritesheet.FileName);

                bwLoadSpritesheet.RunWorkerAsync();
            }
        }

        private void toggleControls(bool enabled)
        {
            bttAddImage.Enabled = enabled;
            bttDelete.Enabled = enabled;
            bttOpenSpritesheet.Enabled = enabled;
            bttPickFolder.Enabled = enabled;
            bttSave.Enabled = enabled;
            tbFileName.Enabled = enabled;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            //if(_controller)
            List<ImageControl> ImageControlsToRemove = new List<ImageControl> () ;
            foreach( ImageControl x in flpContent.Controls)
            {
                if (x.Selected) 
                {
                    ImageControlsToRemove.Add(x);
                }
            }
            foreach (ImageControl x in ImageControlsToRemove)
            {
                flpContent.Controls.Remove(x);
                _controller.Images.Remove(x.SpriteName);
            }


            /*
            for (int i = 0; i < flpContent.Controls.Count; i++) 
            {
                if (((ImageControl)flpContent.Controls[i]).Selected)
                {
                    flpContent.Controls.Remove(flpContent.Controls[i]);
                    i--;
                }
            }
             */
        }
    }
}
