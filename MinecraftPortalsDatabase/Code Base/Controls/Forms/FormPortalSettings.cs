using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormPortalSettings : Form
    {
        private readonly Dictionary<NumericUpDown, NumericUpDown> _dependentCouples;
        private readonly Dictionary<Dimension, ComboBox> _comboBoxes;

        private bool _isReplacementPortal;

        public FormPortalSettings()
        {
            InitializeComponent();

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

            _comboBoxes = new Dictionary<Dimension, ComboBox>()
            {
                { Dimension.Overworld, _cmbBiomeOverworld },
                { Dimension.The_Nether, _cmbBiomeNether }
            };

            _numOverworldX.Tag = _numOverworldZ.Tag = Dimension.Overworld;
            _numNetherX.Tag = _numNetherZ.Tag = Dimension.The_Nether;

            AddNumericUpDownEvents();
            OnOverworldCheckedChanged(_chbOverworld, EventArgs.Empty);
            OnNetherCheckedChanged(_chbNether, EventArgs.Empty);
        }

        public event Action<Portal> PortalDataChanged;

        public bool IsReplacementPortal
        {
            get => _isReplacementPortal;
            set => SetReplacementPortal(value);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public void SetPortalDataValues(Portal portal)
        {
            RemoveNumericUpDownEvents();

            _txtName.Text = portal.Name;

            SetBiomeInComboBox(_cmbBiomeOverworld, portal.BiomeOverworld);
            SetBiomeInComboBox(_cmbBiomeNether, portal.BiomeNether);

            (_numOverworldX.Value, _numOverworldY.Value, _numOverworldZ.Value) = portal.LocationOverworld.XYZ;
            (_numNetherX.Value, _numNetherY.Value, _numNetherZ.Value) = portal.LocationNether.XYZ;

            AddNumericUpDownEvents();
        }

        public void SetBiomes(Dimension dimention, IEnumerable<string> biomes)
        {
            if (_comboBoxes.ContainsKey(dimention))
            {
                ControlsSetter.SetComboBoxValues(_comboBoxes[dimention], biomes, Biomes.DefaultName);
            }
        }

        private void SetBiomeInComboBox(ComboBox box, string biome)
        {
            if (box.Items.Contains(biome))
            {
                box.SelectedItem = biome;
                box.Items.Remove(Biomes.DefaultName);
            }
            else
            {
                if (box.Items.Contains(Biomes.DefaultName) == false)
                {
                    box.Items.Add(Biomes.DefaultName);
                }

                box.SelectedItem = Biomes.DefaultName;
            }
        }

        private void SetReplacementPortal(bool isReplacementPortal)
        {
            _isReplacementPortal = isReplacementPortal;
            _btnApply.Text = isReplacementPortal ? "Edit" : "Add";
        }

        private void AddNumericUpDownEvents()
        {
            foreach (var numeric in _dependentCouples.Keys)
            {
                numeric.ValueChanged += OnNumericUpDownValueChanged;
            }
        }

        private void RemoveNumericUpDownEvents()
        {
            foreach (var numeric in _dependentCouples.Keys)
            {
                numeric.ValueChanged -= OnNumericUpDownValueChanged;
            }
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
            var name = _txtName.Text;
            var biomeOverworld = _cmbBiomeOverworld.SelectedItem.ToString();
            var biomeNether = _cmbBiomeNether.SelectedItem.ToString();
            var locationOverworld = new Point3((int)_numOverworldX.Value, (int)_numOverworldY.Value, (int)_numOverworldZ.Value);
            var locationNether = new Point3((int)_numNetherX.Value, (int)_numNetherY.Value, (int)_numNetherZ.Value);
            var portal = new Portal(name, biomeOverworld, biomeNether, locationOverworld, locationNether);

            PortalDataChanged?.Invoke(portal);
        }

        private void OnOverworldCheckedChanged(object sender, EventArgs e)
        {
            SetNumericUpDownsStyle(_chbOverworld.Checked, _numOverworldX, _numOverworldZ);
        }

        private void OnNetherCheckedChanged(object sender, EventArgs e)
        {
            SetNumericUpDownsStyle(_chbNether.Checked, _numNetherX, _numNetherZ);
        }

        private void OnNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown num && _dependentCouples.ContainsKey(num) && _dependentCouples[num].ReadOnly)
            {
                if ((Dimension)num.Tag == Dimension.Overworld)
                    _dependentCouples[num].Value = num.Value / Point3.DimensionShiftCoefficient;
                else
                    _dependentCouples[num].Value = num.Value * Point3.DimensionShiftCoefficient;
            }
        }
    }
}