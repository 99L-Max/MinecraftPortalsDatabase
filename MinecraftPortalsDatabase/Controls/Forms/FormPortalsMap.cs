using System.Collections.Generic;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormPortalsMap : Form
    {
        private readonly Map _map;

        public FormPortalsMap(IEnumerable<MapPoint> points)
        {
            InitializeComponent();

            _map = new Map(points)
            {
                Dock = DockStyle.Fill,
                BackColor = BackColor,
            };

            Controls.Add(_map);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) =>
            _map.Dispose();
    }
}
