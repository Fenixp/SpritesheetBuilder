using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpritesheetBuilderBackend.Entities;

namespace SpritesheetBuilder
{
    public partial class ImageControl : UserControl
    {
        public EImage Image { get; set; }

        public ImageControl()
        {
            InitializeComponent();
        }

        private void ImageControl_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.Image;
            tbImageName.Text = Image.Name;
        }
    }
}
