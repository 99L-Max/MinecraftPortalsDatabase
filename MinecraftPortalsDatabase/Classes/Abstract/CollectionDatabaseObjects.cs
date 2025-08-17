using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    abstract class CollectionDatabaseObjects : SavingDataJson
    {
        protected Dictionary<string, DatabaseObject> _collection = new Dictionary<string, DatabaseObject>();

        public CollectionDatabaseObjects(string fileName) : base(fileName) { }

        public bool IsEmpty => _collection.Count == 0;

        private bool ShowWarning(string text, bool result = false)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

        private bool CheckDatabaseObject(DatabaseObject obj)
        {
            if (obj == null)
                return ShowWarning($"Object reference does not point to an instance of an object.");

            if (obj.Name == string.Empty)
                return ShowWarning($"The name of the object is not specified.");

            if (obj.Name.Any(DatabaseObject.ForbiddenCharacters.Contains))
                return ShowWarning($"The object name cannot contain characters {DatabaseObject.ForbiddenCharacters}.");

            if (_collection.ContainsKey(obj.Name))
                return ShowWarning($"The object named {obj.Name} already exists in the database.");

            return true;
        }

        protected void SetCollection(DatabaseObject[] databaseObjects)
        {
            if (databaseObjects != null)
                _collection = databaseObjects.ToDictionary(k => k.Name, v => v);
        }

        public bool Add(DatabaseObject obj)
        {
            if (CheckDatabaseObject(obj))
            {
                _collection.Add(obj.Name, obj);
                return true;
            }

            return false;
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

            if (CheckDatabaseObject(newObject))
            {
                var pairs = _collection.ToArray();
                var index = Array.IndexOf(_collection.Keys.ToArray(), nameOldObject);

                pairs[index] = new KeyValuePair<string, DatabaseObject>(newObject.Name, newObject);
                _collection = pairs.ToDictionary(k => k.Key, v => v.Value);

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
