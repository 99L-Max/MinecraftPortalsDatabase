using System;

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

        public static int Square(int value) =>
            value * value;

        public static double GetDistance(Point3 p1, Point3 p2) =>
            Math.Sqrt(Square(p1.X - p2.X) + Square(p1.Y - p2.Y) + Square(p1.Z - p2.Z));

        public static Portal GetNearestPortal(Dimension dimension, Point3 location, params Portal[] portals)
        {
            var nearestPortal = portals[0];
            var distance = GetDistance(nearestPortal.GetLocation(dimension), location);
            var min = distance;

            for(int i = 1; i < portals.Length; i++)
            {
                distance = GetDistance(portals[i].GetLocation(dimension), location);

                if (distance < min)
                {
                    min = distance;
                    nearestPortal = portals[i];
                }
            }

            return nearestPortal;
        }
    }
}
