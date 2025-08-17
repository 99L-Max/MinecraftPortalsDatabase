namespace MinecraftPortalsDatabase
{
    abstract class DatabaseObject
    {
        public const string ForbiddenCharacters = "\\/:*?\"<>|";

        public string Name { get; set; }

        public override string ToString() => Name;

        public abstract object[] ToDataGridViewRow();

        public abstract DatabaseObject GetCopy();
    }
}
