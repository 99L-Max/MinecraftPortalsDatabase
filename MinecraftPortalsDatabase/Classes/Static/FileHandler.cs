using MinecraftPortalsDatabase.Properties;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    class FileHandler
    {
        public static readonly string PathLocalAppData;

        static FileHandler() =>
            PathLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + $@"\{typeof(Program).Namespace}";

        public static void CreateSaveDirectory() =>
            Directory.CreateDirectory(PathLocalAppData);

        public static T[] ReadArray<T>(string path)
        {
            try { return JsonConvert.DeserializeObject<T[]>(File.ReadAllText(path)); }
            catch (Exception) { return null; }
        }

        public static void CreateWorldFolder(string worldName) =>
            Directory.CreateDirectory($@"{PathLocalAppData}\{worldName}");

        public static void RenameWorldFolder(string oldNameWorld, string newNameWorld)
        {
            if (oldNameWorld == newNameWorld) return;
            try { Directory.Move($@"{PathLocalAppData}\{oldNameWorld}", $@"{PathLocalAppData}\{newNameWorld}"); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public static void RemoveWorldFolder(string worldName)
        {
            try { Directory.Delete($@"{PathLocalAppData}\{worldName}", true); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public static void SaveIconWorld(string worldName, Image icon)
        {
            try { icon.Save($@"{PathLocalAppData}\{worldName}\icon.png"); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public static Image ReadIconWorld(string worldName)
        {
            try
            {
                using (var image = new Bitmap($@"{PathLocalAppData}\{worldName}\icon.png"))
                    return new Bitmap(image);
            }
            catch (Exception)
            {
                return Resources.Default_World_Icon;
            }
        }

        public static Image OpenImageFromFile()
        {
            using (var ofDialog = new OpenFileDialog() { Filter = "Изображения|*.jpg;*.jpeg;*.png;" })
                if (ofDialog.ShowDialog() == DialogResult.OK)
                    using (var image = new Bitmap(ofDialog.FileName))
                        return new Bitmap(image);

            return null;
        }
    }
}