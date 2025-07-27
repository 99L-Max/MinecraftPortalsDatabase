using Newtonsoft.Json;
using System.IO;

namespace MinecraftPortalsDatabase
{
    abstract class DataSaving
    {
        public readonly string FullPathFile;

        public DataSaving(string path, string fileName) =>
            FullPathFile = $@"{path}\{fileName}.json";

        protected void Save(object data)
        {
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText(FullPathFile, json);
        }

        public abstract void Save();
    }
}
