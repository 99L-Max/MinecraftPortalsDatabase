using System;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    public partial class FormDatabaseWorlds : Form
    {
        private readonly WorldsCollection _worlds = new WorldsCollection();
        private bool _selectionChanged;

        public event Action<FormDatabaseWorlds, string> WorldSelected;

        public FormDatabaseWorlds()
        {
            InitializeComponent();
            foreach (var obj in _worlds.ToDataGridView()) _dataGridView.Rows.Add(obj);
        }

        private void ShowFormWorldSettings(string name = "")
        {
            var form = new FormWorldSettings(name);
            form.WorldDataChanged += OnWorldDataChanged;
            form.ShowDialog();
        }

        private void OnWorldDataChanged(FormWorldSettings sender, World world)
        {
            if (sender.IsReplacementWorld)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_worlds.Replace(name, world))
                {
                    sender.Close();
                    FileHandler.RenameJsonFile(name, world.Name);

                    var items = world.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];
                }
            }
            else if (_worlds.Add(world))
            {
                sender.Close();
                _dataGridView.Rows.Add(world.ToDataGridViewRow());
            }
        }

        private void OnOpenClick(object sender, EventArgs e) =>
            WorldSelected?.Invoke(this, $"{_dataGridView.SelectedRows[0].Cells[0].Value}");

        private void OnAddClick(object sender, EventArgs e) =>
            ShowFormWorldSettings();

        private void OnEditClick(object sender, EventArgs e) =>
            ShowFormWorldSettings($"{_dataGridView.SelectedRows[0].Cells[0].Value}");

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the selected world?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_worlds.Remove(name))
                {
                    _dataGridView.Rows.Remove(row);
                    FileHandler.RemoveJsonFile(name);
                }
            }
        }

        private void OnDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_selectionChanged) _dataGridView.ClearSelection();
            _selectionChanged = !_selectionChanged;
        }

        private void OnDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            _btnOpen.Enabled = _btnEdit.Enabled = _btnRemove.Enabled = _dataGridView.SelectedRows.Count == 1;
            _selectionChanged = true;
        }
    }
}
