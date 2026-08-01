using System;

namespace MinecraftPortalsDatabase
{
    class Portal : DatabaseObject
    {
        public Portal(string name, string biomeOverworld, string biomeNether, Point3 locationOverworld, Point3 locationNether) : base(name)
        {
            BiomeOverworld = biomeOverworld;
            BiomeNether = biomeNether;
            LocationOverworld = locationOverworld;
            LocationNether = locationNether;
        }

        public string BiomeOverworld { get; }
        public string BiomeNether { get; }
        public Point3 LocationOverworld { get; }
        public Point3 LocationNether { get; }

        public override string ToString()
        {
            return
            $"{Name}{Environment.NewLine}" +
            $"Overworld: {LocationOverworld} ({BiomeOverworld}){Environment.NewLine}" +
            $"The Nether: {LocationNether} ({BiomeNether})";
        }

        public Point3 GetLocation(Dimension dimension)
        {
            return dimension == Dimension.Overworld ? LocationOverworld : LocationNether;
        }

        public override object[] ToDataGridViewRow()
        {
            return new object[] { Name, BiomeOverworld, BiomeNether, LocationOverworld, LocationNether };
        }

        public override DatabaseObject Clone()
        {
            return new Portal(Name, BiomeOverworld, BiomeNether, LocationOverworld, LocationNether);
        }
    }
}
