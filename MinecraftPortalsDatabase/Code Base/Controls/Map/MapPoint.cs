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

        public string Info { get; }
        public Size Size { get; }
        public PointF Location { get; }
        public Image Image { get; }

        public void Dispose()
        { 
            Image?.Dispose();
        }
    }
}