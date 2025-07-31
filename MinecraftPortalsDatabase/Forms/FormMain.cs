using MinecraftPortalsDatabase.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormMain : Form
    {
        private readonly PortalsCollection _portals = new PortalsCollection();
        private readonly FormPortalSettings _formPortalSettings = new FormPortalSettings();
        private readonly FormNearestPortal _formNearestPortal = new FormNearestPortal();
        private readonly DataTable _dataTable = new DataTable();
        private readonly DataGridViewRowFilter _filter = new DataGridViewRowFilter(ColumnNames.Name, ColumnNames.BiomeOverworld, ColumnNames.BiomeNether);

        private bool _selectionChanged;

        public FormMain()
        {
            InitializeComponent();
            ControlsSetter.SetColumns(_dataGridView, _dataTable, JsonManager.GetDictionary<ColumnNames, string>(Resources.Dictionary_ColumnNames));

            _filter.FilterChanged += OnFilterChanged;
            _formPortalSettings.PortalDataChanged += OnPortalDataChanged;
            _formNearestPortal.LocationSelected += _portals.GetStringNearestPortal;

            _formNearestPortal.FormClosing += OnFormDialogClosing;
            _formNearestPortal.FormClosing += OnFormDialogClosing;

            foreach (var obj in _portals.ToDataGridView())
                _dataTable.Rows.Add(obj);

            _btnNearestPortal.Enabled = !_portals.IsEmpty;

            OnDataGridViewSelectionChanged(_dataGridView, EventArgs.Empty);
            CorrectDataGridViewHeight();
            UpdateFilterValues();
        }

        private IEnumerable<string> GetColumnValues(ColumnNames columnName)
        {
            for (int i = 0; i < _dataGridView.RowCount; i++)
                yield return _dataGridView.Rows[i].Cells[$"{columnName}"].Value.ToString();
        }

        private void ShowFormPortalSettings(bool isReplacementPortal)
        {
            _formPortalSettings.IsReplacementPortal = isReplacementPortal;
            _formPortalSettings.ShowDialog();
        }

        private void CorrectDataGridViewHeight()
        {
            var headerHeight = _dataGridView.ColumnHeadersHeight;
            var rowHeight = _dataGridView.RowTemplate.Height;
            var rowCount = _dataGridView.Rows.Count;
            var totalHeight = headerHeight + (rowCount * rowHeight);
            var maxHeight = ClientSize.Height - _dataGridView.Top - 20;

            _dataGridView.Height = Math.Min(totalHeight, maxHeight);
        }

        private void UpdateFilterValues()
        {
            foreach (var column in _filter.FilterableColumns)
                _filter.UpdateValues(column, GetColumnValues(column));
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
            var portal = _portals.GetCopyPortal(name);

            _formPortalSettings.SetPortalDataValues(portal);
            ShowFormPortalSettings(true);
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the selected portals?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                    if (_portals.Remove(row.Cells[0].Value.ToString()))
                        _dataGridView.Rows.Remove(row);

                _btnNearestPortal.Enabled = !_portals.IsEmpty;
                _formNearestPortal.ClearText();

                CorrectDataGridViewHeight();
                UpdateFilterValues();
            }
        }

        private void OnNearestPortalClick(object sender, EventArgs e) =>
            _formNearestPortal.ShowDialog();

        private void OnClearFiltersClick(object sender, EventArgs e) =>
            _filter.Clear();

        private void OnPortalDataChanged(Portal portal)
        {
            if (_formPortalSettings.IsReplacementPortal)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_portals.Replace(name, portal))
                {
                    _formPortalSettings.Hide();
                    _formNearestPortal.ClearText();

                    var items = portal.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];

                    UpdateFilterValues();
                }
            }
            else if (_portals.Add(portal))
            {
                _formPortalSettings.Hide();
                _formNearestPortal.ClearText();
                _dataTable.Rows.Add(portal.ToDataGridViewRow());
                _btnNearestPortal.Enabled = true;

                CorrectDataGridViewHeight();
                UpdateFilterValues();
            }
        }

        private void OnFilterChanged(string filter)
        {
            _dataTable.DefaultView.RowFilter = filter;
            _btnClearFilters.Enabled = filter != string.Empty;
            CorrectDataGridViewHeight();
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

        private void OnFormSizeChanged(object sender, EventArgs e) =>
            CorrectDataGridViewHeight();

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            FileHandler.CreateSaveDirectory();
            _portals.Save();
        }
    }
}