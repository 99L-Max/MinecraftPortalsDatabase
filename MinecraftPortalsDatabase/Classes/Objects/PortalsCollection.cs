using System.Collections.Generic;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    class PortalsCollection : CollectionDatabaseObjects
    {
        public PortalsCollection(string worldName) : base($@"{worldName}\Portals")
        {
            SetCollection(FileHandler.ReadArray<Portal>(FullPathFile));
        }

        public string GetStringNearestPortal(HashSet<string> namesPortals, Dimension dimension, Point3 location) =>
            $"{MathCustom.GetNearestPortal(dimension, location, _collection.Where(x => namesPortals.Contains(x.Key)).Select(x => x.Value as Portal).ToArray())}";

        public IEnumerable<string> GetColumn(int indexColumn) =>
            _collection.Values.Select(x => x.ToDataGridViewRow()[indexColumn].ToString());
    }
}
