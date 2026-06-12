using MinecraftPortalsDatabase.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    static class FileReader
    {
        public static bool TryOpenImageFromFile(out Image image)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Изображения|*.jpg;*.jpeg;*.png;" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap openedImage = new Bitmap(dialog.FileName))
                        image = new Bitmap(openedImage);

                    return true;
                }
                else
                {
                    image = null;
                    return false;
                }
            }
        }

        public static bool TryReadArrayFromJson<T>(string filePath, out T[] array)
        {
            try
            {
                array = JsonConvert.DeserializeObject<T[]>(File.ReadAllText(filePath));
                return true;
            }
            catch (Exception)
            {
                array = new T[0];
                return false;
            }
        }

        public static Image ReadIconWorld(string worldName)
        {
            try
            {
                string filename = DatabaseDirectory.GetPathToWorldIcon(worldName);

                using (Bitmap image = new Bitmap(filename))
                    return new Bitmap(image);
            }
            catch (Exception)
            {
                return Resources.Default_World_Icon;
            }
        }

        public static Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(byte[] jsonResource)
        {
            return JsonConvert.DeserializeObject<Dictionary<TKey, TValue>>(Encoding.UTF8.GetString(jsonResource));
        }
    }
}
