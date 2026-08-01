using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    class PortalsCollection : CollectionDatabaseObjects
    {
        public PortalsCollection(string worldName) : base($@"{worldName}\Portals")
        {
            if (FileReader.TryReadArrayFromJson(PathToFile, out Portal[] portals))
            {
                SetCollection(portals);
            }
        }

        public string GetStringNearestPortal(HashSet<string> namesPortals, Dimension dimension, Point3 location)
        {
            var portals = DatabaseObjects.Where(data => namesPortals.Contains(data.Key)).Select(data => data.Value as Portal);
            var nearestPortal = MathCustom.GetNearestPortal(dimension, location, portals);
            return nearestPortal.ToString();
        }

        public IEnumerable<MapPoint> GetMapPoints(IEnumerable<string> names)
        {
            foreach (DatabaseObject data in DatabaseObjects.Values)
            {
                if (data is Portal portal)
                {
                    Color color = names.Contains(portal.Name) ? Color.BlueViolet : Color.Gray;
                    yield return new MapPoint($"{portal}", portal.LocationOverworld, color);
                }
            }
        }

        public IEnumerable<string> GetColumn(int index)
        {
            return DatabaseObjects.Values.Select(data => data.ToDataGridViewRow()[index].ToString());
        }
    }
}
