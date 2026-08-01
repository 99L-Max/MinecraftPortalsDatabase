using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    static class EnumReader
    {
        public static IEnumerable<T> GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static IEnumerable<string> GetEnumValuesString<T>()
        {
            return GetEnumValues<T>().Select(value => value.ToString().Replace("_", " "));
        }
    }
}
