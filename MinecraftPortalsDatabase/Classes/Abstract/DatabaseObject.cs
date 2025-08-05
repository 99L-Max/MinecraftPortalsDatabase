namespace MinecraftPortalsDatabase
{
    abstract class DatabaseObject
    {
        public string Name { get; set; }

        public override string ToString() => Name;

        public abstract object[] ToDataGridViewRow();

        public abstract DatabaseObject GetCopy();
    }
}
