using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpritesheetReader.DataStructures
{
    public class SpriteInfo
    {
        Image _image;
        Rectangle _rectangle;
        string _name;

        public SpriteInfo(string name, Rectangle size, Image texture)
        {
            _image = texture;
            _name = name;
            _rectangle = size;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Image Image
        {
            get
            {
                return _image;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }
        }
    }
}
