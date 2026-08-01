using System;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormBiomeSettings : Form
    {
        private readonly Biomes _biomes;

        public FormBiomeSettings(Biomes biomes)
        {
            InitializeComponent();
            _biomes = biomes;

            ControlsSetter.SetComboBoxValues(_cmbDimension, EnumReader.GetEnumValuesString<Dimension>());
            ControlsSetter.SetComboBoxValues(_cmbAction, new string[] { "Add biome", "Remove biome" });
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

        private void AddBiome()
        {
            var dimension = (Dimension)_cmbDimension.SelectedIndex;
            var biome = _txtInput.Text;

            if (_biomes.TryAdd(dimension, biome, out string nameAddedBiome))
            {
                MessageBox.Show("Biome added", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateComboBoxValues(dimension);
                _txtInput.Text = nameAddedBiome;
                _biomes.Save();
            }
        }

        private void RemoveBiome()
        {
            var dimension = (Dimension)_cmbDimension.SelectedIndex;
            var biome = _cmbBiome.SelectedItem.ToString();

            if (_biomes.TryRemove(dimension, biome))
            {
                MessageBox.Show("Biome removed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateComboBoxValues(dimension);
                _biomes.Save();
            }
        }

        private void UpdateComboBoxValues(Dimension dimension)
        {
            ControlsSetter.SetComboBoxValues(_cmbBiome, _biomes.GetNames(dimension), Biomes.DefaultName);
        }

        private void OnApplyClick(object sender, EventArgs e)
        {
            if (_cmbAction.SelectedIndex == 0)
                AddBiome();
            else
                RemoveBiome();
        }

        private void OnActionSelectedIndexChanged(object sender, EventArgs e)
        {
            _txtInput.Visible = _cmbAction.SelectedIndex == 0;
            _cmbBiome.Visible = _cmbAction.SelectedIndex == 1;
        }

        private void OnDimensionSelectedIndexChanged(object sender, EventArgs e)
        {
            var dimension = (Dimension)_cmbDimension.SelectedIndex;
            ControlsSetter.SetComboBoxValues(_cmbBiome, _biomes.GetNames(dimension));
        }
    }
}
