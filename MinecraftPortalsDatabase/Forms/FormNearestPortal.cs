using System;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormNearestPortal : Form
    {
        public event Func<Dimension, Point3, string> LocationSelected;

        public FormNearestPortal()
        {
            InitializeComponent();

            ControlsSetter.SetComboBoxValues(_cmbDimension, EnumHandler.GetEnumValuesString<Dimension>());
            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueX, Point3.MaxValueX, _numX);
            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueY, Point3.MaxValueY, _numY);
            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueZ, Point3.MaxValueZ, _numZ);
        }

        private void OnFindClick(object sender, EventArgs e)
        {
            var dimension = (Dimension)_cmbDimension.SelectedIndex;
            var location = new Point3((int)_numX.Value, (int)_numY.Value, (int)_numZ.Value);

            _txtResult.Text = LocationSelected?.Invoke(dimension, location);
        }

        private void OnLocationChanged(object sender, EventArgs e) =>
            _txtResult.Text = string.Empty;

        public void ClearText() =>
            _txtResult.Text = string.Empty;
    }
}
