using System.Collections.Generic;
using System.Drawing;
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

        public IEnumerable<string> GetColumn(int index) =>
            _collection.Values.Select(x => x.ToDataGridViewRow()[index].ToString());

        public IEnumerable<MapPoint> GetMapPoints(IEnumerable<string> names) =>
            _collection.Select(x => x.Value as Portal).Select(p => new MapPoint($"{p}", p.LocationOverworld, names.Contains(p.Name) ? Color.BlueViolet : Color.Gray));
    }
}
