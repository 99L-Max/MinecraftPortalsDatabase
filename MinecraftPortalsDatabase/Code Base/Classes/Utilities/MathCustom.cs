using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    static class MathCustom
    {
        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        public static float Clamp(float value, float min, float max)
        {
            return value < min ? min : value > max ? max : value;
        }

        public static int GetSquare(int value)
        {
            return value * value;
        }

        public static float GetSquare(float value)
        {
            return value * value;
        }

        public static float GetSquareDistance(PointF p1, PointF p2)
        {
            return GetSquare(p1.X - p2.X) + GetSquare(p1.Y - p2.Y);
        }

        public static float GetSquareDistance(Point3 p1, Point3 p2)
        {
            return GetSquare(p1.X - p2.X) + GetSquare(p1.Y - p2.Y) + GetSquare(p1.Z - p2.Z);
        }

        public static float GetDifferenceMaxMin(params MapPoint[] points)
        {
            var minX = points.Min(point => point.Location.X);
            var minY = points.Min(point => point.Location.Y);
            var maxX = points.Max(point => point.Location.X);
            var maxY = points.Max(point => point.Location.Y);

            return Math.Max(maxX, maxY) - Math.Min(minX, minY);
        }

        public static Portal GetNearestPortal(Dimension dimension, Point3 location, IEnumerable<Portal> portals)
        {
            Portal nearestPortal = portals.FirstOrDefault();

            float min = float.MaxValue;
            float squareDistance;

            foreach (Portal portal in portals)
            {
                squareDistance = GetSquareDistance(portal.GetLocation(dimension), location);

                if (squareDistance < min)
                {
                    min = squareDistance;
                    nearestPortal = portal;
                }
            }

            return nearestPortal;
        }
    }
}
