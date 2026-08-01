namespace MinecraftPortalsDatabase
{
    class World : DatabaseObject
    {
        public World(string name) : base(name) { }

        public override object[] ToDataGridViewRow()
        {
            return new object[] { FileReader.ReadIconWorld(Name), Name };
        }

        public override DatabaseObject Clone()
        {
            return new World(Name);
        }
    }
}