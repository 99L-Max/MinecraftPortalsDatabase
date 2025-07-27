using Newtonsoft.Json;
using System;
using System.IO;

namespace MinecraftPortalsDatabase
{
    class FileHandler
    {
        public static readonly string PathLocalAppData;

        static FileHandler() =>
            PathLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + $@"\{typeof(Program).Namespace}";

        public static void CreateSaveDirectory() =>
            Directory.CreateDirectory(PathLocalAppData);

        public static Portal[] ReadPortals(string path)
        {
            try
            {
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<Portal[]>(json);
            }
            catch (Exception) { }
            return null;
        }
    }
}
