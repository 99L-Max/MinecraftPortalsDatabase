namespace MinecraftPortalsDatabase
{
    class WorldsCollection : CollectionDatabaseObjects
    {
        public WorldsCollection() : base("Worlds")
        { 
            SetCollection(FileHandler.ReadArray<World>(FullPathFile)); 
        }
    }
}
