using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class FormWorldSettings : Form
    {
        private readonly Pen _penIconBorder;

        private bool _isHovered = false;

        public FormWorldSettings(World world)
        {
            InitializeComponent();
            IsReplacementWorld = world != null;

            if (IsReplacementWorld)
            {
                _txtName.Text = world.Name;
                _pbIcon.Image?.Dispose();
                _pbIcon.Image = FileReader.ReadIconWorld(world.Name);
                _btnApply.Text = "Edit";
            }

            _penIconBorder = new Pen(Color.White, 2f) { Alignment = PenAlignment.Inset };
        }

        public event Action<FormWorldSettings, World, Image> WorldDataChanged;

        public bool IsReplacementWorld { get; }

        private void OnApplyClick(object sender, EventArgs e)
        {
            using (Bitmap icon = new Bitmap(_pbIcon.Image))
                WorldDataChanged?.Invoke(this, new World(_txtName.Text), icon);
        }

        private void OnSelectIcon(object sender, EventArgs e)
        {
            if (FileReader.TryOpenImageFromFile(out Image image))
            {
                _pbIcon.Image?.Dispose();
                _pbIcon.Image = Painter.CreateIcon(image);

                image.Dispose();
            }
        }

        private void OnIconMouseEnter(object sender, EventArgs e)
        {
            _isHovered = true;
            _pbIcon.Invalidate();
        }

        private void OnIconMouseLeave(object sender, EventArgs e)
        {
            _isHovered = false;
            _pbIcon.Invalidate();
        }

        private void OnIconPaint(object sender, PaintEventArgs e)
        {
            if (_isHovered)
                e.Graphics.DrawRectangle(_penIconBorder, _pbIcon.ClientRectangle);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _penIconBorder.Dispose();
            _pbIcon.Image?.Dispose();
        }
    }
}