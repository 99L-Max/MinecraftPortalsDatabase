using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormPortalSettings : Form
    {
        private readonly Dictionary<NumericUpDown, NumericUpDown> _dependentCouples;

        private bool _isReplacementPortal;

        public event Action<Portal> PortalDataChanged;

        public FormPortalSettings()
        {
            InitializeComponent();

            ControlsSetter.SetComboBoxValues(_cmbBiomeOverworld, EnumHandler.GetBiomesString(Dimension.Overworld));
            ControlsSetter.SetComboBoxValues(_cmbBiomeNether, EnumHandler.GetBiomesString(Dimension.The_Nether));

            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueX, Point3.MaxValueX, _numOverworldX, _numNetherX);
            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueY, Point3.MaxValueY, _numOverworldY, _numNetherY);
            ControlsSetter.SetNumericUpDownBounds(Point3.MinValueZ, Point3.MaxValueZ, _numOverworldZ, _numNetherZ);

            _dependentCouples = new Dictionary<NumericUpDown, NumericUpDown>()
            {
                { _numOverworldX, _numNetherX },
                { _numOverworldZ, _numNetherZ },
                { _numNetherX, _numOverworldX },
                { _numNetherZ, _numOverworldZ }
            };

            _numOverworldX.Tag = _numOverworldZ.Tag = Dimension.Overworld;
            _numNetherX.Tag = _numNetherZ.Tag = Dimension.The_Nether;

            AddNumericUpDownEvents();
            OnOverworldCheckedChanged(_chbOverworld, EventArgs.Empty);
            OnNetherCheckedChanged(_chbNether, EventArgs.Empty);
        }

        public bool IsReplacementPortal
        {
            get => _isReplacementPortal;
            set
            {
                _isReplacementPortal = value;
                _btnApply.Text = value ? "Edit" : "Add";
            }
        }

        public void SetPortalDataValues(Portal portal)
        {
            RemoveNumericUpDownEvents();

            _txtName.Text = portal.Name;
            _cmbBiomeOverworld.SelectedIndex = (int)portal.BiomeOverworld;
            _cmbBiomeNether.SelectedIndex = (int)portal.BiomeNether;

            (_numOverworldX.Value, _numOverworldY.Value, _numOverworldZ.Value) = portal.LocationOverworld.TupleXYZ;
            (_numNetherX.Value, _numNetherY.Value, _numNetherZ.Value) = portal.LocationNether.TupleXYZ;

            AddNumericUpDownEvents();
        }

        private void AddNumericUpDownEvents()
        {
            foreach (var pair in _dependentCouples)
                pair.Key.ValueChanged += OnNumericUpDownValueChanged;
        }

        private void RemoveNumericUpDownEvents()
        {
            foreach (var pair in _dependentCouples)
                pair.Key.ValueChanged -= OnNumericUpDownValueChanged;
        }

        private void SetNumericUpDownsStyle(bool isReadonly, params NumericUpDown[] nums)
        {
            foreach (var num in nums)
            {
                num.ReadOnly = isReadonly;
                num.ForeColor = isReadonly ? Color.Red : Color.White;
            }
        }

        private void OnApplyClick(object sender, EventArgs e)
        {
            var portal = new Portal
            {
                Name = _txtName.Text,
                BiomeOverworld = (BiomeOverworld)_cmbBiomeOverworld.SelectedIndex,
                BiomeNether = (BiomeNether)_cmbBiomeNether.SelectedIndex,
                LocationOverworld = new Point3((int)_numOverworldX.Value, (int)_numOverworldY.Value, (int)_numOverworldZ.Value),
                LocationNether = new Point3((int)_numNetherX.Value, (int)_numNetherY.Value, (int)_numNetherZ.Value)
            };

            PortalDataChanged?.Invoke(portal);
        }

        private void OnOverworldCheckedChanged(object sender, EventArgs e) =>
            SetNumericUpDownsStyle(_chbOverworld.Checked, _numOverworldX, _numOverworldZ);

        private void OnNetherCheckedChanged(object sender, EventArgs e) =>
            SetNumericUpDownsStyle(_chbNether.Checked, _numNetherX, _numNetherZ);

        private void OnNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown num && _dependentCouples.ContainsKey(num) && _dependentCouples[num].ReadOnly)
                _dependentCouples[num].Value = (Dimension)num.Tag == Dimension.Overworld ? num.Value / Point3.DimensionShiftCoefficient : num.Value * Point3.DimensionShiftCoefficient;
        }
    }
}
