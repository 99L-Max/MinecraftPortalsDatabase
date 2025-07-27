namespace MinecraftPortalsDatabase
{
    struct Point3
    {
        public const int DimensionShiftCoefficient = 8;

        public const int MinValueX = -30000000;
        public const int MinValueY = -64;
        public const int MinValueZ = -30000000;

        public const int MaxValueX = 30000000;
        public const int MaxValueY = 319;
        public const int MaxValueZ = 30000000;

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3(int x, int y, int z)
        {
            X = MathCustom.CorrectValue(x, MinValueX, MaxValueX);
            Y = MathCustom.CorrectValue(y, MinValueY, MaxValueY);
            Z = MathCustom.CorrectValue(z, MinValueZ, MaxValueZ);
        }

        public (int x, int y, int z) TupleXYZ => (X, Y, Z);

        public override string ToString() =>
            $"{X}, {Y}, {Z}";

        public static Point3 operator *(int left, Point3 right) =>
            new Point3(left * right.X, left * right.Y, left * right.Z);

        public static Point3 operator /(Point3 left, int right) =>
            new Point3(left.X / right, left.Y / right, left.Z / right);
    }
}
