using SpritesheetBuilderBackend.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using SpritesheetBuilderBackend.Resources;
using SpritesheetBuilderBackend.Entities;

namespace SpritesheetBuilderBackend.Controllers
{
    public class SpritesheetBuilderController
    {
        private List<EImage> _images = new List<EImage>();

        public ImageFilesReadResult ImageFilesRead(string[] sourceFiles)
        {
            ImageFilesReadResult result = new ImageFilesReadResult();

            foreach (string sourceFile in sourceFiles)
            {
                try
                {
                    _images.Add(new EImage {
                        Image = Image.FromFile(sourceFile),
                        Name = Path.GetFileNameWithoutExtension(sourceFile)
                    });
                }
                catch (FileNotFoundException)
                {
                    result.AddError(String.Format(SpritesheetBuilderRX.WrongFileFormat, sourceFile));
                }
                catch
                {
                    result.AddError(String.Format(SpritesheetBuilderRX.WrongFileFormat, sourceFile));
                }
            }

            return result;
        }

        public IEnumerable<EImage> Images
        {
            get
            {
                return _images;
            }
        }
    }
}
