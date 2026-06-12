using System;
using System.IO;

namespace MinecraftPortalsDatabase
{
    static class DatabaseDirectory
    {
        static DatabaseDirectory() =>
            SavingPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{typeof(Program).Namespace}";

        public static string SavingPath { get; }

        public static void CreateSaveDirectory() =>
            Directory.CreateDirectory(SavingPath);

        public static string GetPathToDirectory(string worldName) =>
            $@"{SavingPath}\{worldName}";

        public static string GetPathToWorldIcon(string worldName) =>
            $@"{SavingPath}\{worldName}\icon.png";
    }
}
