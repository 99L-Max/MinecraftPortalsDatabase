namespace MinecraftPortalsDatabase
{
    class World : DatabaseObject
    {
        public World(string name) : base(name) { }

        public override object[] ToDataGridViewRow() =>
            new object[] { FileReader.ReadIconWorld(Name), Name };

        public override DatabaseObject Clone() =>
            new World(Name);
    }
}