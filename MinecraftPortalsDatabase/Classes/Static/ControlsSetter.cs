using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    static class ControlsSetter
    {
        public static void SetComboBoxValues(ComboBox box, IEnumerable<object> objects)
        {
            box.Items.Clear();
            box.Items.AddRange(objects.ToArray());
            box.SelectedIndex = 0;
        }

        public static void SetNumericUpDownBounds(decimal min, decimal max, params NumericUpDown[] nums)
        {
            foreach (var num in nums)
                (num.Minimum, num.Maximum) = (min, max);
        }

        public static void SetColumns<TKey, TValue>(DataGridView dataGridView, DataTable dataTable, Dictionary<TKey, TValue> columns)
        {
            dataTable.Columns.AddRange(columns.Select(x => new DataColumn(x.Key.ToString())).ToArray());
            dataGridView.DataSource = dataTable;

            var i = 0;

            foreach (var column in columns)
            {
                dataGridView.Columns[i].HeaderText = column.Value.ToString();
                dataGridView.Columns[i].ReadOnly = true;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                i++;
            }
        }
    }
}
