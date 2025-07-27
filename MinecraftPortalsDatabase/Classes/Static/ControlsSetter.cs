using System.Collections.Generic;
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
    }
}
