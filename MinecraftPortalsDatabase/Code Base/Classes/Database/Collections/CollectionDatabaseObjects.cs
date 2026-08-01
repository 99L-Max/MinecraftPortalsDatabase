using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    abstract class CollectionDatabaseObjects
    {
        protected Dictionary<string, DatabaseObject> DatabaseObjects = new Dictionary<string, DatabaseObject>();

        public CollectionDatabaseObjects(string fileName)
        {
            PathToFile = $@"{DatabaseDirectory.SavingPath}\{fileName}.json";
        }

        public string PathToFile { get; }

        public bool IsEmpty => DatabaseObjects.Count == 0;

        public void Save()
        {
            File.WriteAllText(PathToFile, JsonConvert.SerializeObject(DatabaseObjects.Values));
        }

        public bool TryAdd(DatabaseObject dataObject)
        {
            if (IsDatabaseObjectCorrect(dataObject))
            {
                DatabaseObjects.Add(dataObject.Name, dataObject);
                return true;
            }

            return false;
        }

        public bool TryRemove(string name)
        {
            return DatabaseObjects.Remove(name);
        }

        public bool TryReplace(string nameOldObject, DatabaseObject newObject)
        {
            if (DatabaseObjects.ContainsKey(nameOldObject) == false)
            {
                return false;
            }

            if (nameOldObject == newObject.Name)
            {
                DatabaseObjects[nameOldObject] = newObject;
                return true;
            }

            if (IsDatabaseObjectCorrect(newObject))
            {
                var pairs = DatabaseObjects.ToArray();
                var index = Array.IndexOf(DatabaseObjects.Keys.ToArray(), nameOldObject);

                pairs[index] = new KeyValuePair<string, DatabaseObject>(newObject.Name, newObject);
                DatabaseObjects = pairs.ToDictionary(key => key.Key, value => value.Value);

                return true;
            }

            return false;
        }

        public bool TryClone(string name, out DatabaseObject database)
        {
            if (DatabaseObjects.ContainsKey(name))
            {
                database = DatabaseObjects[name].Clone();
                return true;
            }
            else
            {
                database = null;
                return false;
            }
        }

        public object[][] ToDataGridView()
        {
            return DatabaseObjects.Values.Select(dataObject => dataObject.ToDataGridViewRow()).ToArray();
        }

        protected void SetCollection(DatabaseObject[] databaseObjects)
        {
            if (databaseObjects != null)
            {
                DatabaseObjects = databaseObjects.ToDictionary(dataObject => dataObject.Name, dataObject => dataObject);
            }
        }

        private bool IsDatabaseObjectCorrect(DatabaseObject dataObject)
        {
            if (dataObject == null)
            {
                ShowWarning($"Object reference does not point to an instance of an object.");
                return false;
            }

            if (dataObject.Name == string.Empty)
            {
                ShowWarning($"The name of the object is not specified.");
                return false;
            }

            if (dataObject.Name.Any(DatabaseObject.ForbiddenCharacters.Contains))
            {
                ShowWarning($"The object name cannot contain characters {DatabaseObject.ForbiddenCharacters}.");
                return false;
            }

            if (DatabaseObjects.ContainsKey(dataObject.Name))
            {
                ShowWarning($"The object named {dataObject.Name} already exists in the database.");
                return false;
            }

            return true;
        }

        private void ShowWarning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
