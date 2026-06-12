using Newtonsoft.Json;

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

        public Point3(int x, int y, int z)
        {
            X = MathCustom.Clamp(x, MinValueX, MaxValueX);
            Y = MathCustom.Clamp(y, MinValueY, MaxValueY);
            Z = MathCustom.Clamp(z, MinValueZ, MaxValueZ);
        }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        [JsonIgnore]
        public (int x, int y, int z) XYZ => (X, Y, Z);

        public override string ToString() => $"{X}, {Y}, {Z}";
    }
}
