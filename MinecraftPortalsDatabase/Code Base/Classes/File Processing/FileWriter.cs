using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    static class FileWriter
    {
        public static void CreateWorldDirectory(string worldName)
        {
            Directory.CreateDirectory(DatabaseDirectory.GetPathToDirectory(worldName));
        }

        public static void RenameWorldDirectory(string oldWorldName, string newWorldName)
        {
            if (oldWorldName == newWorldName)
            {
                return;
            }

            try
            {
                var oldPath = DatabaseDirectory.GetPathToDirectory(oldWorldName);
                var newPath = DatabaseDirectory.GetPathToDirectory(newWorldName);
                Directory.Move(oldPath, newPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void RemoveWorldDirectory(string worldName)
        {
            try
            {
                Directory.Delete(DatabaseDirectory.GetPathToDirectory(worldName), true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void SaveIconWorld(string worldName, Image icon)
        {
            try
            {
                icon.Save(DatabaseDirectory.GetPathToWorldIcon(worldName));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}