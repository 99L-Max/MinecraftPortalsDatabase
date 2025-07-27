using System;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormMain : Form
    {
        private readonly PortalsCollection _portals = new PortalsCollection();
        private readonly FormPortalSettings _formPortalSettings = new FormPortalSettings();
        private readonly FormNearestPortal _formNearestPortal = new FormNearestPortal();

        private bool _selectionChanged;

        public FormMain()
        {
            InitializeComponent();

            _formPortalSettings.PortalDataChanged += OnPortalDataChanged;
            _formNearestPortal.LocationSelected += _portals.GetStringNearestPortal;

            _formNearestPortal.FormClosing += OnFormDialogClosing;
            _formNearestPortal.FormClosing += OnFormDialogClosing;

            foreach (var obj in _portals.ToDataGridView())
                _dataGridView.Rows.Add(obj);

            _btnNearestPortal.Enabled = !_portals.IsEmpty;

            OnDataGridViewSelectionChanged(_dataGridView, EventArgs.Empty);
            CorrectDataGridViewHeight();
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
            if (!_portals.IsEmpty && DialogResult.Yes == MessageBox.Show("Do you really want to delete the selected portals?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                    if (_portals.Remove(row.Cells[0].Value.ToString()))
                        _dataGridView.Rows.Remove(row);
            
                _btnNearestPortal.Enabled = !_portals.IsEmpty;
                CorrectDataGridViewHeight();
            }
        }

        private void OnNearestPortalClick(object sender, EventArgs e) =>
            _formNearestPortal.ShowDialog();

        private void OnPortalDataChanged(Portal portal)
        {
            if (_formPortalSettings.IsReplacementPortal)
            {
                var row = _dataGridView.SelectedRows[0];
                var name = row.Cells[0].Value.ToString();

                if (_portals.Replace(name, portal))
                {
                    var items = portal.ToDataGridViewRow();

                    for (int i = 0; i < items.Length && i < row.Cells.Count; i++)
                        row.Cells[i].Value = items[i];

                    _formPortalSettings.Hide();
                }
            }
            else if (_portals.Add(portal))
            {
                _dataGridView.Rows.Add(portal.ToDataGridViewRow());
                _formPortalSettings.Hide();
                _btnNearestPortal.Enabled = true;
                CorrectDataGridViewHeight();
            }
        }

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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            FileHandler.CreateSaveDirectory();
            _portals.Save();
        }

        private void OnFormSizeChanged(object sender, EventArgs e) =>
            CorrectDataGridViewHeight();
    }
}