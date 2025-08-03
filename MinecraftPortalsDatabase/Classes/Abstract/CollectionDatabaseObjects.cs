using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    abstract class CollectionDatabaseObjects : DataSaving
    {
        protected readonly Dictionary<string, DatabaseObject> _collection = new Dictionary<string, DatabaseObject>();

        public CollectionDatabaseObjects(string fileName) : base(fileName) { }

        public bool IsEmpty =>
            _collection.Count == 0;

        protected void SetCollection(DatabaseObject[] databaseObjects)
        {
            _collection.Clear();

            if (databaseObjects != null)
                foreach (var obj in databaseObjects)
                    _collection.Add(obj.Name, obj);
        }

        public bool Add(DatabaseObject obj)
        {
            if (obj.Name == string.Empty)
            {
                MessageBox.Show($"The name of the object is not specified.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_collection.ContainsKey(obj.Name))
            {
                MessageBox.Show($"The object named {obj.Name} already exists in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _collection.Add(obj.Name, obj);
            return true;
        }

        public bool Remove(string name) =>
            _collection.Remove(name);

        public bool Replace(string nameOldObject, DatabaseObject newObject)
        {
            if (!_collection.ContainsKey(nameOldObject))
                return false;

            if (nameOldObject == newObject.Name)
            {
                _collection[nameOldObject] = newObject;
                return true;
            }

            if (Add(newObject))
            {
                _collection.Remove(nameOldObject);
                return true;
            }

            return false;
        }

        public object[][] ToDataGridView() =>
            _collection.Values.Select(x => x.ToDataGridViewRow()).ToArray();

        public DatabaseObject GetCopyObject(string name) =>
            _collection[name].GetCopy();

        public override void Save() =>
            Save(_collection.Values);
    }
}
