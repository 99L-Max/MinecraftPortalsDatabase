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

        public FormColumnFilter(ColumnNames columnName, IEnumerable<string> values)
        {
            InitializeComponent();

            _checkedListBox.Items.AddRange(values.OrderBy(x => x).ToArray());
            ColumnName = columnName;
        }

        private void OnFilterClick(object sender, EventArgs e) =>
            ValuesSelected?.Invoke(ColumnName, _checkedListBox.CheckedItems.OfType<string>());

        private void OnCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                var isChecked = e.NewValue == CheckState.Checked;

                for (int i = 1; i < _checkedListBox.Items.Count; i++)
                    _checkedListBox.SetItemChecked(i, isChecked);
            }
        }
    }
}
