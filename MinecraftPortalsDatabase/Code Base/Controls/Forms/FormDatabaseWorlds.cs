using System;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    public partial class FormDatabaseWorlds : Form
    {
        private readonly WorldsCollection _worlds = new WorldsCollection();

        private bool _selectionChanged;

        public FormDatabaseWorlds()
        {
            InitializeComponent();

            foreach (var dataObject in _worlds.ToDataGridView())
                _dataGridView.Rows.Add(dataObject);

            OnDataGridViewSelectionChanged(_dataGridView, EventArgs.Empty);
        }

        public event Action<FormDatabaseWorlds, string> WorldSelected;

        private void ShowFormWorldSettings(World world = null)
        {
            var form = new FormWorldSettings(world);
            form.WorldDataChanged += OnWorldDataChanged;
            form.ShowDialog();
        }

        private void OnWorldDataChanged(FormWorldSettings sender, World world, Image icon)
        {
            if (sender.IsReplacementWorld)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[$"{WorldsTableColumnNames.WorldName}"].Value.ToString();

                if (_worlds.TryReplace(name, world))
                {
                    sender.Close();
                    _worlds.Save();

                    FileWriter.RenameWorldDirectory(name, world.Name);
                    FileWriter.SaveIconWorld(world.Name, icon);

                    var items = world.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];
                }
            }
            else if (_worlds.TryAdd(world))
            {
                sender.Close();
                _worlds.Save();

                FileWriter.CreateWorldDirectory(world.Name);
                FileWriter.SaveIconWorld(world.Name, icon);

                _dataGridView.Rows.Add(world.ToDataGridViewRow());
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        { 
            WorldSelected?.Invoke(this, $"{_dataGridView.SelectedRows[0].Cells[$"{WorldsTableColumnNames.WorldName}"].Value}");
        }

        private void OnAddClick(object sender, EventArgs e)
        { 
            ShowFormWorldSettings();
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            var name = $"{_dataGridView.SelectedRows[0].Cells[$"{WorldsTableColumnNames.WorldName}"].Value}";

            if (_worlds.TryClone(name, out DatabaseObject world))
                ShowFormWorldSettings(world as World);
            else
                MessageBox.Show($"The world named \"{name}\" was not found");
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the selected world?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[$"{WorldsTableColumnNames.WorldName}"].Value.ToString();

                if (_worlds.TryRemove(name))
                {
                    _worlds.Save();
                    _dataGridView.Rows.Remove(row);

                    FileWriter.RemoveWorldDirectory(name);
                }
            }
        }

        private void OnDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_selectionChanged == false)
                _dataGridView.ClearSelection();

            _selectionChanged = !_selectionChanged;
        }

        private void OnDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            _btnOpen.Enabled = _btnEdit.Enabled = _btnRemove.Enabled = _dataGridView.SelectedRows.Count == 1;
            _selectionChanged = true;
        }
    }
}