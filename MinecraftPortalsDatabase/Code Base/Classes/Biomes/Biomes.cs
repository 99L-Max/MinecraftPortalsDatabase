using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    class Biomes
    {
        public const string DefaultName = "NOT_FOUND";

        private readonly Dictionary<Dimension, List<string>> _biomes;

        public Biomes()
        {
            PathToFile = $@"{DatabaseDirectory.SavingPath}\Biomes.json";
            _biomes = FileReader.GetBiomesFromFile(PathToFile);
        }

        public event Action<Dimension> BiomesChanged;

        public string PathToFile { get; }

        public bool TryAdd(Dimension dimension, string input, out string nameAddedBiome)
        {
            var biome = CorrectName(input);

            if (IsNameCorrect(dimension, biome))
            {
                _biomes[dimension].Add(biome);
                nameAddedBiome = biome;

                BiomesChanged?.Invoke(dimension);
                return true;
            }

            nameAddedBiome = string.Empty;
            return false;
        }

        public bool TryRemove(Dimension dimension, string input)
        {
            if (_biomes[dimension].Remove(input))
            {
                BiomesChanged?.Invoke(dimension);
                return true;
            }

            ShowError("Biome not found");
            return false;
        }

        public IEnumerable<string> GetNames(Dimension dimension)
        {
            return _biomes[dimension].OrderBy(biome => biome);
        }

        public void Save()
        {
            File.WriteAllText(PathToFile, JsonConvert.SerializeObject(_biomes));
        }

        private bool IsNameCorrect(Dimension dimension, string formattedBiomeName)
        {
            if (formattedBiomeName == string.Empty)
            {
                ShowError("Incorrect biome name");
                return false;
            }

            if (_biomes[dimension].Contains(formattedBiomeName))
            {
                ShowError("The specified biome already exists");
                return false;
            }

            return true;
        }

        private string CorrectName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var words = Regex.Split(input, @"[^a-zA-Z]+");

            return string.Join("_", words.Where(word => string.IsNullOrEmpty(word) == false).Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
