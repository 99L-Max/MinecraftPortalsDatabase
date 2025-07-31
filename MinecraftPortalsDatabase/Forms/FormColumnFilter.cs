using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormColumnFilter : Form
    {
        public readonly ColumnNames ColumnName;
        public event Action<ColumnNames, IEnumerable<string>> ValuesSelected;

        public FormColumnFilter(ColumnNames columnName, Dictionary<string, bool> items)
        {
            InitializeComponent();

            foreach (var item in items.OrderBy(x => x.Key))
                _checkedListBox.Items.Add(item.Key, item.Value);

            ColumnName = columnName;
        }

        private void OnFilterClick(object sender, EventArgs e) =>
            ValuesSelected?.Invoke(ColumnName, _checkedListBox.CheckedItems.OfType<string>());

        private void OnCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
                for (int i = 1; i < _checkedListBox.Items.Count; i++)
                    _checkedListBox.SetItemChecked(i, e.NewValue == CheckState.Checked);
        }

        public Dictionary<string, bool> GetValues()
        {
            var dict = new Dictionary<string, bool>();

            for (int i = 1; i < _checkedListBox.Items.Count; i++)
                dict.Add(_checkedListBox.Items[i].ToString(), _checkedListBox.GetItemChecked(i));

            return dict;
        }
    }
}
