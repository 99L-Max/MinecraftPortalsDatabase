namespace MinecraftPortalsDatabase
{
    class World : DatabaseObject
    {
        public override object[] ToDataGridViewRow() =>
            new object[] { FileHandler.ReadIconWorld(Name), Name };

        public override DatabaseObject GetCopy() =>
            new World() { Name = Name };
    }
}