using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormColumnFilter : Form
    {
        public FormColumnFilter(string columnName, IReadOnlyDictionary<string, bool> checkedValues)
        {
            InitializeComponent();

            foreach (var value in checkedValues.OrderBy(item => item.Key))
                _checkedListBox.Items.Add(value.Key, value.Value);

            ColumnName = columnName;
        }

        public event Action<string, IEnumerable<string>> ValuesSelected;

        public string ColumnName { get; }

        private IEnumerable<string> GetChekedValues()
        {
            for (int i = 1; i < _checkedListBox.Items.Count; i++)
                if (_checkedListBox.GetItemChecked(i))
                    yield return _checkedListBox.Items[i].ToString();
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            ValuesSelected?.Invoke(ColumnName, GetChekedValues());
        }

        private void OnCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
                for (int i = 1; i < _checkedListBox.Items.Count; i++)
                    _checkedListBox.SetItemChecked(i, e.NewValue == CheckState.Checked);
        }
    }
}
