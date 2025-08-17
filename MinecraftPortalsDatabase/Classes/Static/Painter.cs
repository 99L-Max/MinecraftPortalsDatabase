using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MinecraftPortalsDatabase
{
    static class Painter
    {
        public static Image CreateIcon(Image image, int size = 64)
        {
            var result = new Bitmap(size, size);

            using (var g = Graphics.FromImage(result))
            using (var icon = ToSquareImage(image))
                g.DrawImage(icon, 0, 0, size, size);

            return result;
        }

        public static Image ToSquareImage(Image image)
        {
            var size = Math.Min(image.Width, image.Height);
            var result = new Bitmap(size, size);

            using (var g = Graphics.FromImage(result))
                g.DrawImage(image, -(image.Width - size >> 1), -(image.Height - size >> 1), image.Width, image.Height);

            return result;
        }

        public static Image CreateGradientCircle(Color centerColor, int diameter, float focusScales = 0.6f)
        {
            var result = new Bitmap(diameter, diameter);

            using (var g = Graphics.FromImage(result))
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, diameter, diameter);

                using (var pthGrBrush = new PathGradientBrush(path))
                {
                    pthGrBrush.CenterColor = centerColor;
                    pthGrBrush.SurroundColors = new Color[] { Color.Transparent };
                    pthGrBrush.FocusScales = new PointF(focusScales, focusScales);

                    g.FillEllipse(pthGrBrush, 0, 0, diameter, diameter);
                }
            }

            return result;
        }
    }
}