using System.Drawing;

namespace MinecraftPortalsDatabase
{
    static class MathCustom
    {
        public static int CorrectValue(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static float CorrectValue(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static int Square(int value) =>
            value * value;

        public static float Square(float value) =>
            value * value;

        public static float GetSquareDistance(PointF p1, PointF p2) =>
            Square(p1.X - p2.X) + Square(p1.Y - p2.Y);

        public static float GetSquareDistance(Point3 p1, Point3 p2) =>
            Square(p1.X - p2.X) + Square(p1.Y - p2.Y) + Square(p1.Z - p2.Z);

        public static float GetDifferenceMinMax(params MapPoint[] points)
        {
            var min = float.MaxValue;
            var max = float.MinValue;

            foreach (var p in points)
            {
                if (p.Location.X < min) min = p.Location.X;
                if (p.Location.Y < min) min = p.Location.Y;
                if (p.Location.X > max) max = p.Location.X;
                if (p.Location.Y > max) max = p.Location.Y;
            }

            return max - min;
        }

        public static Portal GetNearestPortal(Dimension dimension, Point3 location, params Portal[] portals)
        {
            var nearestPortal = portals[0];
            var squareDistance = GetSquareDistance(nearestPortal.GetLocation(dimension), location);
            var min = squareDistance;

            for(int i = 1; i < portals.Length; i++)
            {
                squareDistance = GetSquareDistance(portals[i].GetLocation(dimension), location);

                if (squareDistance < min)
                {
                    min = squareDistance;
                    nearestPortal = portals[i];
                }
            }

            return nearestPortal;
        }
    }
}
