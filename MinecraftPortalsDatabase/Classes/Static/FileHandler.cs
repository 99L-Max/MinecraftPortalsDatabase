using Newtonsoft.Json;
using System;
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
            try
            {
                Directory.Move($@"{PathLocalAppData}\{oldNameWorld}", $@"{PathLocalAppData}\{newNameWorld}");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void RemoveWorldFolder(string worldName)
        {
            try
            {
                Directory.Delete($@"{PathLocalAppData}\{worldName}", true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
