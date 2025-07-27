using System;

namespace MinecraftPortalsDatabase
{
    class Portal
    {
        public string Name { get; set; }
        public BiomeOverworld BiomeOverworld { get; set; }
        public BiomeNether BiomeNether { get; set; }
        public Point3 LocationOverworld { get; set; }
        public Point3 LocationNether { get; set; }

        public Point3 GetLocation(Dimension dimension) =>
            dimension == Dimension.Overworld ? LocationOverworld : LocationNether;

        public override string ToString() =>
            $"{Name}{Environment.NewLine}" +
            $"Overworld: {LocationOverworld} ({BiomeOverworld}){Environment.NewLine}" +
            $"Nether: {LocationNether} ({BiomeNether})";

        public object[] ToDataGridViewRow() =>
            new object[] { Name, BiomeOverworld, BiomeNether, LocationOverworld, LocationNether };

        public Portal GetCopy() =>
            new Portal
            {
                Name = Name,
                BiomeOverworld = BiomeOverworld,
                BiomeNether = BiomeNether,
                LocationOverworld = LocationOverworld,
                LocationNether = LocationNether
            };
    }
}
