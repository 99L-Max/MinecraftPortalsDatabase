using Newtonsoft.Json;
using System.IO;

namespace MinecraftPortalsDatabase
{
    abstract class SavingDataJson
    {
        public readonly string FullPathFile;

        public SavingDataJson(string jsonFileName) =>
            FullPathFile = $@"{FileHandler.PathLocalAppData}\{jsonFileName}.json";

        protected void Save(object data) =>
            File.WriteAllText(FullPathFile, JsonConvert.SerializeObject(data));

        public abstract void Save();
    }
}
