namespace MinecraftPortalsDatabase
{
    class WorldsCollection : CollectionDatabaseObjects
    {
        public WorldsCollection() : base("Worlds")
        {
            if (FileReader.TryReadArrayFromJson(PathToFile, out World[] worlds))
                SetCollection(worlds);
        }
    }
}
