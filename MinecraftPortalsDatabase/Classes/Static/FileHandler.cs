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
            catch (Exception) { }
            return null;
        }

        public static void RemoveJsonFile(string fileName)
        {
            var path = $@"{PathLocalAppData}\{fileName}.json";
            if(File.Exists(path)) File.Delete(path);
        }

        public static void RenameJsonFile(string oldFileName, string newFileName)
        {
            try
            {
                File.Move($@"{PathLocalAppData}\{oldFileName}.json", $@"{PathLocalAppData}\{newFileName}.json");
                Console.WriteLine("Файл успешно переименован.");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
