using System.Collections.Generic;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    class ColumnFilter
    {
        private Dictionary<string, bool> _optionsCheked = new Dictionary<string, bool>();

        public ColumnFilter(string columnName)
        { 
            ColumnName = columnName;
        }

        public string Filter { get; private set; } = string.Empty;

        public string ColumnName { get; }

        public IReadOnlyDictionary<string, bool> CheckedValues => _optionsCheked;

        public void SetCheckedOptions(IEnumerable<string> options)
        { 
           _optionsCheked = _optionsCheked.Keys.ToDictionary(key => key, key => options.Contains(key));

            var filterOptions = _optionsCheked.Where(option => option.Value).Select(pair => $"{ColumnName} = '{pair.Key}'");

            Filter = string.Join(" OR ", filterOptions);
        }

        public void UpdateOptions(IEnumerable<string> options)
        { 
            _optionsCheked = options.Distinct().ToDictionary(key => key, key => _optionsCheked.ContainsKey(key) == false || _optionsCheked[key]);
        }

        public void Clear()
        {
            _optionsCheked = _optionsCheked.Keys.ToDictionary(key => key, value => true);
            Filter = string.Empty;
        }
    }
}
