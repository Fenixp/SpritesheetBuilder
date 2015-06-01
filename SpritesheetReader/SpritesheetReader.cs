using SpritesheetReader.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpritesheetReader
{
    public static class SpritesheetReader
    {
        private static Dictionary<string, Dictionary<string, SpriteInfo>> _spritesheets = new Dictionary<string, Dictionary<string, SpriteInfo>>();

        public static SpriteInfo GetSprite(string spritesheet, string spriteName)
        {
            SpriteInfo info = TryGetSprite(spritesheet, spriteName);
            if (info == null)
            {
                throw new Exception("SpriteName unknown");
            }
            else
            {
                return info;
            }
        }

        public static SpriteInfo TryGetSprite(string spritesheet, string spriteName)
        {
            if (_spritesheets.ContainsKey(spritesheet))
            {
                if (_spritesheets[spritesheet].ContainsKey(spriteName))
                {
                    return _spritesheets[spritesheet][spriteName];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                Readspritesheet(spritesheet);
                return TryGetSprite(spritesheet, spriteName);
            }
        }

        public static Dictionary<string, SpriteInfo> GetSprites(string spritesheet)
        {
            if (_spritesheets.ContainsKey(spritesheet))
            {
                return _spritesheets[spritesheet];
            }
            else
            {
                Readspritesheet(spritesheet);
                return GetSprites(spritesheet);
            }
        }

        public static List<SpriteInfo> GetAnimation(string spritesheet, string animationName)
        {
            int i = 1;
            SpriteInfo info = TryGetSprite(spritesheet, animationName + (i++).ToString());
            List<SpriteInfo> infos = new List<SpriteInfo>();

            while (info != null)
            {
                infos.Add(info);
                info = TryGetSprite(spritesheet, animationName + (i++).ToString());
            }

            if (infos.Count == 0)
            {
                throw new Exception("AnimationName unknown");
            }

            return infos;
        }

        private static void Readspritesheet(string spritesheet)
        {
            List<string> Lines = ReadLines(spritesheet);
            string FileName = Lines[0];

            if (FileName == null)
            {
                throw new Exception("Incorrect spritesheet file format");
            }

            Lines.RemoveAt(0);
            _spritesheets.Add(spritesheet, ProcessLines(Lines, Image.FromFile(String.Format("{0}\\{1}", ContentSettings.ContentRootDirectory, FileName))));
        }

        private static Dictionary<string, SpriteInfo> ProcessLines(IEnumerable<string> Lines, Image spritesheet)
        {
            Tuple<Rectangle, string> SpriteInfo;
            Dictionary<string, SpriteInfo> sprites = new Dictionary<string, SpriteInfo>();

            foreach (string str in Lines)
            {
                SpriteInfo = TrySplitSprite(str);

                sprites.Add(SpriteInfo.Item2, new SpriteInfo(SpriteInfo.Item2, SpriteInfo.Item1, spritesheet));
            }

            return sprites;
        }

        private static List<string> ReadLines(string spritesheet)
        {
            List<string> Lines = new List<string>();
            string line;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(ContentSettings.ContentRootDirectory + "\\" + spritesheet + ".txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        Lines.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception("spritesheet file was not found. Make sure every spritesheet picture has correctly formatted .txt file attached to it.");
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception("spritesheet directory was not found. Make sure the ListsFolder attribute is set correctly.");
            }

            return Lines;
        }

        private static Tuple<string, int> TrySplitName(string fileLine)
        {
            string[] splitted = fileLine.Split(':');
            if (splitted.Length > 0)
            {
                return new Tuple<string, int>((string)splitted[0], Int16.Parse(splitted[1]));
            }
            else
            {
                return null;
            }
        }

        private static Tuple<Rectangle, string> TrySplitSprite(string fileLine)
        {
            string[] splitted = fileLine.Split(' ');
            if (splitted.Length > 0)
            {
                return new Tuple<Rectangle, string>(new Rectangle(Int16.Parse(splitted[0]), Int16.Parse(splitted[1]), Int16.Parse(splitted[2]), Int16.Parse(splitted[3])), (string)splitted[4]);
            }
            else
            {
                return null;
            }
        }
    }
}
