namespace MinecraftPortalsDatabase
{
    class World : DatabaseObject
    {
        public PortalsCollection GetPortalsCollectionFromFile() =>
            new PortalsCollection(Name);

        public override object[] ToDataGridViewRow() =>
            new object[] { Name };

        public override DatabaseObject GetCopy() =>
            new World() { Name = Name };
    }
}
