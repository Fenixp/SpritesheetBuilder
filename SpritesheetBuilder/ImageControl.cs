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

        private string _name;

        private static SpritesheetBuilderController _controller;

        public ImageControl(SpritesheetBuilderController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ImageControl_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image;
            _name = tbImageName.Text;
        }

        private void tbImageName_Leave(object sender, EventArgs e)
        {
            if (_name != tbImageName.Text)
            {
                changeImageName();
            }
        }

        private void tbImageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_name != tbImageName.Text && e.KeyChar == ENTER_KEY_CODE)
            {
                changeImageName();
            }
        }

        private void changeImageName()
        {
            try
            {
                _controller.RenameImage(_name, tbImageName.Text);
                _name = tbImageName.Text;
            }
            catch
            {
                MessageBox.Show(String.Format(SpritesheetBuilderRX.DuplicateImageName, tbImageName.Text), SpritesheetBuilderRX.DuplicateImageNameTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbImageName.Text = _name;
            }
        }
    }
}
