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
            foreach (NumericUpDown num in nums)
                (num.Minimum, num.Maximum) = (min, max);
        }

        public static void SetColumns<TKey, TValue>(DataGridView dataGridView, DataTable dataTable, Dictionary<TKey, TValue> columnsValues)
        {
            var columns = columnsValues.Select(column => new DataColumn(column.Key.ToString()));
            var i = 0;

            dataTable.Columns.AddRange(columns.ToArray());
            dataGridView.DataSource = dataTable;

            foreach (var value in columnsValues.Values)
            {
                dataGridView.Columns[i].HeaderText = value.ToString();
                dataGridView.Columns[i].ReadOnly = true;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                i++;
            }
        }
    }
}
