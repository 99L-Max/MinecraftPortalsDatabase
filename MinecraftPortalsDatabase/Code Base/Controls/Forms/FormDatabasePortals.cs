using MinecraftPortalsDatabase.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormDatabasePortals : Form
    {
        private readonly DataTable _dataTable = new DataTable();
        private readonly FormPortalSettings _formPortalSettings = new FormPortalSettings();
        private readonly FormNearestPortal _formNearestPortal = new FormNearestPortal();
        private readonly PortalsCollection _portals;
        private readonly DataGridViewColumnsFilter _filter;

        private bool _selectionChanged;

        public FormDatabasePortals(string worldName)
        {
            InitializeComponent();

            PortalsTableColumnNames[] filterableColumns = { PortalsTableColumnNames.Name, PortalsTableColumnNames.BiomeOverworld, PortalsTableColumnNames.BiomeNether };

            _portals = new PortalsCollection(worldName);
            _filter = new DataGridViewColumnsFilter(filterableColumns.Select(column => column.ToString()));

            ControlsSetter.SetColumns(_dataGridView, _dataTable, FileReader.GetDictionary<PortalsTableColumnNames, string>(Resources.Dictionary_PortalsTableColumnNames));

            foreach (var portal in _portals.ToDataGridView())
                _dataTable.Rows.Add(portal);

            _filter.FilterChanged += OnFilterChanged;
            _formPortalSettings.PortalDataChanged += OnPortalDataChanged;
            _formNearestPortal.LocationSelected += _portals.GetStringNearestPortal;

            _formPortalSettings.FormClosing += OnFormDialogClosing;
            _formNearestPortal.FormClosing += OnFormDialogClosing;

            _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(PortalsTableColumnNames.Name));
            _btnNearestPortal.Enabled = _btnMap.Enabled = !_portals.IsEmpty;

            OnDataGridViewSelectionChanged(_dataGridView, EventArgs.Empty);
            UpdateFilterValues();
        }

        public event Action AnotherWorldSelecting;

        private IEnumerable<string> GetDataGridViewColumns(PortalsTableColumnNames column)
        {
            for (int i = 0; i < _dataGridView.RowCount; i++)
                yield return _dataGridView.Rows[i].Cells[$"{column}"].Value.ToString();
        }

        private void ShowFormPortalSettings(bool isReplacementPortal)
        {
            _formPortalSettings.IsReplacementPortal = isReplacementPortal;
            _formPortalSettings.ShowDialog();
        }

        private void UpdateFilterValues()
        {
            foreach (var column in _filter.FilterableColumns)
                _filter.UpdateValues(column, _portals.GetColumn(_dataGridView.Columns[column].Index));
        }

        private void OnFormDialogClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Form form && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Hide();
            }
        }

        private void OnAddClick(object sender, EventArgs e)
        { 
            ShowFormPortalSettings(false);
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            var name = _dataGridView.SelectedRows[0].Cells[0].Value.ToString();

            if (_portals.TryClone(name, out DatabaseObject portal))
            {
                _formPortalSettings.SetPortalDataValues(portal as Portal);
                ShowFormPortalSettings(true);
            }
            else
            {
                MessageBox.Show($"The portal named \"{name}\" was not found");
            }
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the selected portals?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                    if (_portals.TryRemove(row.Cells[0].Value.ToString()))
                        _dataGridView.Rows.Remove(row);

                _portals.Save();
                _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(PortalsTableColumnNames.Name));
                _btnNearestPortal.Enabled = _btnMap.Enabled = !_portals.IsEmpty;

                UpdateFilterValues();
            }
        }

        private void OnMapClick(object sender, EventArgs e)
        {
            var names = GetDataGridViewColumns(PortalsTableColumnNames.Name);
            var points = _portals.GetMapPoints(names);
            new FormPortalsMap(points).ShowDialog();
        }

        private void OnNearestPortalClick(object sender, EventArgs e)
        { 
            _formNearestPortal.ShowDialog();
        }

        private void OnClearFiltersClick(object sender, EventArgs e)
        { 
            _filter.Clear();
        }

        private void OnSelectAnotherWorldClick(object sender, EventArgs e)
        { 
            AnotherWorldSelecting?.Invoke();
        }

        private void OnPortalDataChanged(Portal portal)
        {
            if (_formPortalSettings.IsReplacementPortal)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_portals.TryReplace(name, portal))
                {
                    _formPortalSettings.Hide();
                    _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(PortalsTableColumnNames.Name));
                    _portals.Save();

                    var items = portal.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];

                    UpdateFilterValues();
                }
            }
            else if (_portals.TryAdd(portal))
            {
                _formPortalSettings.Hide();
                _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(PortalsTableColumnNames.Name));
                _portals.Save();
                _dataTable.Rows.Add(portal.ToDataGridViewRow());
                _btnNearestPortal.Enabled = _btnMap.Enabled = true;

                UpdateFilterValues();
            }
        }

        private void OnFilterChanged(string filter)
        {
            _dataTable.DefaultView.RowFilter = filter;
            _btnClearFilters.Enabled = filter != string.Empty;
            _btnNearestPortal.Enabled = _btnMap.Enabled = _dataGridView.RowCount > 0;
            _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(PortalsTableColumnNames.Name));
        }

        private void OnDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            _filter.ShowFormFilter(_dataGridView.Columns[e.ColumnIndex].Name);
        }

        private void OnDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_selectionChanged == false)
                _dataGridView.ClearSelection();

            _selectionChanged = !_selectionChanged;
        }

        private void OnDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            _btnRemove.Enabled = _dataGridView.SelectedRows.Count > 0;
            _btnEdit.Enabled = _dataGridView.SelectedRows.Count == 1;
            _selectionChanged = true;
        }
    }
}