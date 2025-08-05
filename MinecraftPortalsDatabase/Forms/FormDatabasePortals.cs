using MinecraftPortalsDatabase.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormDatabasePortals : Form
    {
        private readonly DataTable _dataTable = new DataTable();
        private readonly DataGridViewRowFilter _filter = new DataGridViewRowFilter(ColumnNames.Name, ColumnNames.BiomeOverworld, ColumnNames.BiomeNether);
        private readonly FormPortalSettings _formPortalSettings = new FormPortalSettings();
        private readonly FormNearestPortal _formNearestPortal = new FormNearestPortal();
        private readonly PortalsCollection _portals;

        private bool _selectionChanged;

        public event Action SelectAnotherWorld;

        public FormDatabasePortals(string worldName)
        {
            InitializeComponent();
            _portals = new PortalsCollection(worldName);

            ControlsSetter.SetColumns(_dataGridView, _dataTable, JsonManager.GetDictionary<ColumnNames, string>(Resources.Dictionary_ColumnNames));
            foreach (var obj in _portals.ToDataGridView()) _dataTable.Rows.Add(obj);

            _filter.FilterChanged += OnFilterChanged;
            _formPortalSettings.PortalDataChanged += OnPortalDataChanged;
            _formNearestPortal.LocationSelected += _portals.GetStringNearestPortal;

            _formPortalSettings.FormClosing += OnFormDialogClosing;
            _formNearestPortal.FormClosing += OnFormDialogClosing;

            _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(ColumnNames.Name));
            _btnNearestPortal.Enabled = !_portals.IsEmpty;

            OnDataGridViewSelectionChanged(_dataGridView, EventArgs.Empty);
            UpdateFilterValues();
        }

        private IEnumerable<string> GetDataGridViewColumns(ColumnNames column)
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
                _filter.UpdateValues(column, _portals.GetColumn(column));
        }

        private void OnFormDialogClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Form form && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Hide();
            }
        }

        private void OnAddClick(object sender, EventArgs e) =>
            ShowFormPortalSettings(false);

        private void OnEditClick(object sender, EventArgs e)
        {
            var name = _dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            var portal = _portals.GetCopyObject(name);

            _formPortalSettings.SetPortalDataValues(portal as Portal);
            ShowFormPortalSettings(true);
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the selected portals?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                    if (_portals.Remove(row.Cells[0].Value.ToString()))
                        _dataGridView.Rows.Remove(row);

                _portals.Save();
                _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(ColumnNames.Name));
                _btnNearestPortal.Enabled = !_portals.IsEmpty;

                UpdateFilterValues();
            }
        }

        private void OnNearestPortalClick(object sender, EventArgs e) =>
            _formNearestPortal.ShowDialog();

        private void OnClearFiltersClick(object sender, EventArgs e) =>
            _filter.Clear();

        private void OnSelectAnotherWorldClick(object sender, EventArgs e) =>
            SelectAnotherWorld?.Invoke();

        private void OnPortalDataChanged(Portal portal)
        {
            if (_formPortalSettings.IsReplacementPortal)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_portals.Replace(name, portal))
                {
                    _formPortalSettings.Hide();
                    _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(ColumnNames.Name));
                    _portals.Save();

                    var items = portal.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];

                    UpdateFilterValues();
                }
            }
            else if (_portals.Add(portal))
            {
                _formPortalSettings.Hide();
                _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(ColumnNames.Name));
                _portals.Save();
                _dataTable.Rows.Add(portal.ToDataGridViewRow());
                _btnNearestPortal.Enabled = true;

                UpdateFilterValues();
            }
        }

        private void OnFilterChanged(string filter)
        {
            _dataTable.DefaultView.RowFilter = filter;
            _btnClearFilters.Enabled = filter != string.Empty;
            _btnNearestPortal.Enabled = _dataGridView.RowCount > 0;
            _formNearestPortal.SetNamesPortals(GetDataGridViewColumns(ColumnNames.Name));
        }

        private void OnDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) =>
            _filter.ShowFormFilter((ColumnNames)e.ColumnIndex);

        private void OnDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_selectionChanged) _dataGridView.ClearSelection();
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