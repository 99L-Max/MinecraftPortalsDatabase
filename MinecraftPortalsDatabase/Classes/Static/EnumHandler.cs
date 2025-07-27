using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    static class EnumHandler
    {
        public static IEnumerable<T> GetEnumValues<T>() =>
            Enum.GetValues(typeof(T)).Cast<T>();

        public static IEnumerable<string> GetEnumValuesString<T>() =>
            GetEnumValues<T>().Select(x => x.ToString().Replace("_", " "));

        public static IEnumerable<string> GetBiomesString(Dimension dimension) =>
            dimension == Dimension.Overworld ? GetEnumValuesString<BiomeOverworld>() : GetEnumValuesString<BiomeNether>();
    }
}
