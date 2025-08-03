using System;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormWorldSettings : Form
    {
        public readonly bool IsReplacementWorld;
        public event Action<FormWorldSettings, World> WorldDataChanged;

        public FormWorldSettings(string worldName)
        {
            InitializeComponent();
            IsReplacementWorld = worldName != string.Empty;

            _txtName.Text = worldName;
            _btnApply.Text = IsReplacementWorld ? "Edit" : "Add";
        }

        private void OnApplyClick(object sender, EventArgs e) =>
            WorldDataChanged?.Invoke(this, new World() { Name = _txtName.Text });
    }
}