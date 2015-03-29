using SpritesheetBuilderBackend.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using SpritesheetBuilderBackend.Resources;
using System.Drawing.Imaging;

namespace SpritesheetBuilderBackend.Controllers
{
    public class SpritesheetBuilderController
    {
        private Dictionary<string, Image> _images = new Dictionary<string, Image>();

        public ImageFilesReadResult ImageFilesRead(string[] sourceFiles)
        {
            ImageFilesReadResult result = new ImageFilesReadResult();
            string addWarningMessage;

            foreach (string sourceFile in sourceFiles)
            {
                try
                {
                    AddNewImage(Path.GetFileNameWithoutExtension(sourceFile), Image.FromFile(sourceFile), out addWarningMessage);
                    if (addWarningMessage != String.Empty)
                    {
                        result.AddWarning(addWarningMessage);
                    }
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

        public IDictionary<string, Image> Images
        {
            get
            {
                return _images;
            }
        }

        public void RenameImage(string oldName, string newName)
        {
            if (!_images.ContainsKey(oldName))
            {
                throw new ArgumentException(ExceptionsRX.ImageDoesntExist);
            }

            if (_images.ContainsKey(newName))
            {
                throw new ArgumentException(ExceptionsRX.ImageAlreadyExists);
            }

            Image image = _images[oldName];
            _images.Remove(oldName);
            _images.Add(newName, image);
        }

        public void SaveSpriteSheet(string spritesheetName, string saveFolderPath)
        {
            int x = 0;
            int y = 0;
            int height = 0;
            int line = 0;
            int lineLength = GetLineLength();
            Bitmap spriteSheet = new Bitmap(lineLength * 20, lineLength * 20);
            StringBuilder outText = new StringBuilder();
            outText.AppendLine(spritesheetName + ".png");

            using (Graphics g = Graphics.FromImage(spriteSheet))
            {
                g.Clear(SystemColors.AppWorkspace);

                foreach (KeyValuePair<string, Image> image in _images)
                {
                    g.DrawImage(image.Value, x, y, image.Value.Width, image.Value.Height);
                    outText.AppendLine(String.Format("{0} {1} {2} {3} {4}", 
                        x, 0, image.Value.Width, image.Value.Height, image.Key));

                    x += image.Value.Width;
                    height = image.Value.Height > height ? image.Value.Height : height;

                    if (++line == lineLength)
                    {
                        line = 0;
                        x = 0;
                        y += height;
                    }
                }
            }

            File.WriteAllText(String.Format("{0}\\{1}.txt", saveFolderPath, spritesheetName), outText.ToString());
            spriteSheet.Save(String.Format("{0}\\{1}.png", saveFolderPath, spritesheetName), ImageFormat.Png);
        }

        public bool CheckFileNameValidity(string filePath, string fileName)
        {
            return filePath != String.Empty && fileName != String.Empty;
        }

        private int GetLineLength()
        {
            return (int)Math.Ceiling(Math.Sqrt(_images.Count));
        }

        private int GetSpriteWidths()
        {
            int width = 0;
            foreach (Image image in _images.Values)
            {
                width += image.Width;
            }

            return width;
        }

        private int GetMaxSpriteHeight()
        {
            int height = 0;
            foreach (Image image in _images.Values)
            {
                height = height < image.Height ? image.Height : height;
            }

            return height;
        }

        private void AddNewImage(string name, Image image, out string warningMessages)
        {
            warningMessages = String.Empty;

            if (_images.ContainsKey(name))
            {
                warningMessages = String.Format(SpritesheetBuilderRX.DuplicateImageName, name) + " " + SpritesheetBuilderRX.Renaming;
                _images.Add(RenameDuplicitImage(name), image);
            }
            else
            {
                _images.Add(name, image);
            }
        }

        private string RenameDuplicitImage(string oldName)
        {
            oldName = "_" + oldName;
            if (!_images.ContainsKey(oldName))
            {
                return oldName;
            }
            return RenameDuplicitImage(oldName);
        }
    }
}
