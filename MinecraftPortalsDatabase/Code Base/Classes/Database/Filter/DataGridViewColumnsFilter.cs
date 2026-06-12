using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    class DataGridViewColumnsFilter
    {
        private readonly Dictionary<string, ColumnFilter> _filters;

        public DataGridViewColumnsFilter(IEnumerable<string> columnNames)
        {
            FilterableColumns = new ReadOnlyCollection<string>(columnNames.Distinct().ToList());
            _filters = FilterableColumns.ToDictionary(key => key, key => new ColumnFilter(key));
        }

        public event Action<string> FilterChanged;

        public IReadOnlyCollection<string> FilterableColumns { get; }

        public string Filter { get; private set; }

        public void UpdateValues(string columnName, IEnumerable<string> values)
        {
            if (_filters.ContainsKey(columnName))
                _filters[columnName].UpdateOptions(values);
        }

        public void ShowFormFilter(string columnName)
        {
            if (_filters.ContainsKey(columnName))
            {
                var form = new FormColumnFilter(columnName, _filters[columnName].CheckedValues);

                form.ValuesSelected += OnValuesSelected;
                form.FormClosing += OnFormColumnFilterClosing;

                form.ShowDialog();
            }
        }

        public void Clear()
        {
            foreach (ColumnFilter filter in _filters.Values)
                filter.Clear();

            Filter = string.Empty;
            FilterChanged?.Invoke(string.Empty);
        }

        private void OnValuesSelected(string columnName, IEnumerable<string> values)
        {
            if (_filters.ContainsKey(columnName))
            {
                _filters[columnName].SetCheckedOptions(values);

                var columnsFilters = _filters.Values.Where(filter => filter.Filter != string.Empty).Select(filter => $"({filter.Filter})");

                Filter = string.Join(" AND ", columnsFilters);
                FilterChanged?.Invoke(Filter);
            }
        }

        private void OnFormColumnFilterClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is FormColumnFilter form)
            {
                form.ValuesSelected -= OnValuesSelected;
                form.FormClosing -= OnFormColumnFilterClosing;
            }
        }
    }
}
