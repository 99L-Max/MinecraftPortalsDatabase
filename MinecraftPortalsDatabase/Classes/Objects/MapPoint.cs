using System;
using System.Drawing;

namespace MinecraftPortalsDatabase
{
    class MapPoint : IDisposable
    {
        public MapPoint(string tipText, Point3 locationOnMap, Color color, int size = 15)
        {
            Size = new Size(size, size);
            Image = Painter.CreateGradientCircle(color, size);
            Info = tipText;
            Location = new PointF(locationOnMap.X, locationOnMap.Z);
        }

        public string Info { get; set; }
        public Size Size { get; set; }
        public PointF Location { get; set; }
        public Image Image { get; set; }

        public void Dispose() =>
            Image?.Dispose();
    }
}