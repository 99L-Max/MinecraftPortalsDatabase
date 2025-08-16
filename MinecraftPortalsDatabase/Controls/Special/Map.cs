using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    partial class Map : UserControl
    {
        private readonly MapPoint[] _points;
        private readonly ToolTip _tooltip = new ToolTip();
        private readonly int _squareHitRadius;

        private readonly float _coeffReduceScale = 0.9f;
        private readonly float _coeffIncreaseScale = 1.1f;

        private readonly float _minScale = 0.05f;
        private readonly float _maxScale = 50f;

        private float _scale = 1f;
        private bool _isPanning = false;
        private PointF _offset = new PointF();
        private PointF _centerMap;
        private Point _lastMouseLocation;
        private MapPoint _hoveredPoint = null;

        public Map(IEnumerable<MapPoint> points)
        {
            InitializeComponent();

            var hitRadius = points.Select(x => x.Size.Height).Max();

            var maxX = points.Select(x => x.Location.X).Max();
            var maxY = points.Select(x => x.Location.Y).Max();
            var minX = points.Select(x => x.Location.X).Min();
            var minY = points.Select(x => x.Location.Y).Min();

            var maxLoc = Math.Max(maxX, maxY);
            var minLoc = Math.Min(minX, minY);

            _points = points.ToArray();
            _squareHitRadius = hitRadius * hitRadius;
            _minScale = Screen.PrimaryScreen.Bounds.Size.Width / (maxLoc - minLoc) / 4f;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            TabStop = true;
            OnSizeChanged(this, EventArgs.Empty);
        }

        private PointF GetLocationOnMap(PointF screen) =>
            new PointF((screen.X - _offset.X) / _scale, (screen.Y - _offset.Y) / _scale);

        private RectangleF GetRectangleFOnScreen(MapPoint point) =>
            new RectangleF(point.Location.X * _scale + _offset.X, point.Location.Y * _scale + _offset.Y, point.Size.Width, point.Size.Height);

        private void Zoom(PointF point, int delta)
        {
            var worldBefore = GetLocationOnMap(point);
            var newScale = _scale * (delta > 0 ? _coeffIncreaseScale : _coeffReduceScale);

            _scale = MathCustom.CorrectValue(newScale, _minScale, _maxScale);
            _offset = new PointF(point.X - worldBefore.X * _scale, point.Y - worldBefore.Y * _scale);

            Invalidate();
        }

        private string LocationToString(PointF point) =>
            $"{point.X:F0}; {point.Y:F0}";

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            foreach (var p in _points)
                e.Graphics.DrawImage(p.Image, GetRectangleFOnScreen(p));
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPanning = true;
                _lastMouseLocation = e.Location;

                Cursor = Cursors.Hand;
                Focus();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPanning = false;
                Cursor = Cursors.Default;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_isPanning)
            {
                _offset = new PointF(_offset.X + e.Location.X - _lastMouseLocation.X, _offset.Y + e.Location.Y - _lastMouseLocation.Y);
                _lastMouseLocation = e.Location;

                Invalidate();
            }

            MapPoint found = null;

            foreach (var pt in _points)
            {
                var sp = GetRectangleFOnScreen(pt);
                var squareDistance = MathCustom.GetSquareDistance(sp.Location, e.Location);

                if (squareDistance <= _squareHitRadius)
                {
                    found = pt;
                    break;
                }
            }

            if (found != null)
            {
                if (found != _hoveredPoint)
                {
                    _hoveredPoint = found;
                    _tooltip.Show(found.Info, this, e.Location.X, e.Location.Y, 3000);
                }
            }
            else if (_hoveredPoint != null)
            {
                _hoveredPoint = null;
                _tooltip.Hide(this);
            }

            _labelLocationCursor.Text = LocationToString(GetLocationOnMap(e.Location));
        }

        private void OnMouseWheel(object sender, MouseEventArgs e) =>
            Zoom(e.Location, e.Delta);

        private void OnZoomOutClick(object sender, EventArgs e) =>
            Zoom(_centerMap, -1);

        private void OnZoomInClick(object sender, EventArgs e) =>
            Zoom(_centerMap, 1);

        private void OnSizeChanged(object sender, EventArgs e) =>
            _centerMap = new PointF(ClientSize.Width / 2f, ClientSize.Height / 2f);
    }
}
