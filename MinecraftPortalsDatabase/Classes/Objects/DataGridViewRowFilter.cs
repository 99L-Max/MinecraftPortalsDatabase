using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    class DataGridViewRowFilter
    {
        private readonly Dictionary<ColumnNames, string> _filters = new Dictionary<ColumnNames, string>();
        private readonly Dictionary<ColumnNames, Dictionary<string, bool>> _columnCheckedValues;

        public readonly ReadOnlyCollection<ColumnNames> FilterableColumns;
        public event Action<string> FilterChanged;

        public DataGridViewRowFilter(params ColumnNames[] columnNames)
        {
            FilterableColumns = new ReadOnlyCollection<ColumnNames>(columnNames.Distinct().ToArray());

            _filters = FilterableColumns.ToDictionary(k => k, v => string.Empty);
            _columnCheckedValues = FilterableColumns.ToDictionary(k => k, v => new Dictionary<string, bool>());
        }

        public string Filter { get; private set; }

        private void OnValuesSelected(ColumnNames columnName, IEnumerable<string> values)
        {
            if (!_filters.ContainsKey(columnName)) return;
            _filters[columnName] = values.Count() > 0 ? string.Join(" OR ", values.Select(v => $"{columnName} = '{v}'")) : string.Empty;

            Filter = string.Join(" AND ", _filters.Values.Where(x => x != string.Empty).Select(x => $"({x})"));
            FilterChanged?.Invoke(Filter);
        }

        private void OnFormColumnFilterClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is FormColumnFilter form)
            {
                _columnCheckedValues[form.ColumnName] = form.GetValues();

                form.ValuesSelected -= OnValuesSelected;
                form.FormClosing -= OnFormColumnFilterClosing;
            }
        }

        public void UpdateValues(ColumnNames columnName, IEnumerable<string> values)
        {
            if (_columnCheckedValues.ContainsKey(columnName))
            {
                var dict = _columnCheckedValues[columnName];
                var keysSet = new HashSet<string>(values);
                var keysToRemove = dict.Keys.Where(k => !keysSet.Contains(k)).ToArray();

                foreach (var key in keysSet) if (!dict.ContainsKey(key)) dict.Add(key, true);
                foreach (var key in keysToRemove) dict.Remove(key);
            }
        }

        public void ShowFormFilter(ColumnNames columnName)
        {
            if (!_filters.ContainsKey(columnName)) return;

            var form = new FormColumnFilter(columnName, _columnCheckedValues[columnName]);

            form.ValuesSelected += OnValuesSelected;
            form.FormClosing += OnFormColumnFilterClosing;

            form.ShowDialog();
        }

        public void Clear()
        {
            foreach (var key in FilterableColumns) _filters[key] = string.Empty;
            Filter = string.Empty;
            FilterChanged?.Invoke(string.Empty);
        }
    }
}
