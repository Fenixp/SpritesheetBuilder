using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpritesheetBuilderBackend.Controllers;
using SpritesheetBuilderBackend.Resources;

namespace SpritesheetBuilder
{
    public partial class ImageControl : UserControl
    {
        private const char ENTER_KEY_CODE = (char)13;

        public Image Image { get; set; }

        public bool Selected { get; set; }

        public string SpriteName { get; set; }

        private static SpritesheetBuilderController _controller;

        public ImageControl(SpritesheetBuilderController controller)
        {
            InitializeComponent();
            _controller = controller;
            Selected = false;
        }

        private void ImageControl_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image;
            SpriteName = tbImageName.Text;
        }

        private void tbImageName_Leave(object sender, EventArgs e)
        {
            if (SpriteName != tbImageName.Text)
            {
                changeImageName();
            }
        }

        private void tbImageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SpriteName != tbImageName.Text && e.KeyChar == ENTER_KEY_CODE)
            {
                changeImageName();
            }
        }

        private void changeImageName()
        {
            try
            {
                _controller.RenameImage(SpriteName, tbImageName.Text);
                SpriteName = tbImageName.Text;
            }
            catch
            {
                MessageBox.Show(String.Format(SpritesheetBuilderRX.DuplicateImageName, tbImageName.Text), SpritesheetBuilderRX.DuplicateImageNameTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbImageName.Text = SpriteName;
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
            if (Selected)
            {
                this.BackColor = SystemColors.Highlight; //System.Drawing.Color.Blue;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
