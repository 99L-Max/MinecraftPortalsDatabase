namespace MinecraftPortalsDatabase
{
    abstract class DatabaseObject
    {
        public const string ForbiddenCharacters = "\\/:*?\"<>|";

        public DatabaseObject(string name) => Name = name;

        public string Name { get; }

        public override string ToString() => Name;

        public abstract object[] ToDataGridViewRow();

        public abstract DatabaseObject Clone();
    }
}
