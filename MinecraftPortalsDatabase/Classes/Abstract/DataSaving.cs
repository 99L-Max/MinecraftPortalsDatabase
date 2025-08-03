using Newtonsoft.Json;
using System.IO;

namespace MinecraftPortalsDatabase
{
    abstract class DataSaving
    {
        public readonly string FullPathFile;

        public DataSaving(string fileName) =>
            FullPathFile = $@"{FileHandler.PathLocalAppData}\{fileName}.json";

        protected void Save(object data) =>
            File.WriteAllText(FullPathFile, JsonConvert.SerializeObject(data));

        public abstract void Save();
    }
}
