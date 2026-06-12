using System;

namespace MinecraftPortalsDatabase
{
    class Portal : DatabaseObject
    {
        public Portal(string name, BiomeOverworld biomeOverworld, BiomeNether biomeNether, Point3 locationOverworld, Point3 locationNether) : base(name)
        {
            BiomeOverworld = biomeOverworld;
            BiomeNether = biomeNether;
            LocationOverworld = locationOverworld;
            LocationNether = locationNether;
        }

        public BiomeOverworld BiomeOverworld { get; }
        public BiomeNether BiomeNether { get; }
        public Point3 LocationOverworld { get; }
        public Point3 LocationNether { get; }

        public override string ToString() =>
            $"{Name}{Environment.NewLine}" +
            $"Overworld: {LocationOverworld} ({BiomeOverworld}){Environment.NewLine}" +
            $"The Nether: {LocationNether} ({BiomeNether})";

        public Point3 GetLocation(Dimension dimension) =>
            dimension == Dimension.Overworld ? LocationOverworld : LocationNether;

        public override object[] ToDataGridViewRow() =>
            new object[] { Name, BiomeOverworld, BiomeNether, LocationOverworld, LocationNether };

        public override DatabaseObject Clone() =>
            new Portal(Name, BiomeOverworld, BiomeNether, LocationOverworld, LocationNether);
    }
}
