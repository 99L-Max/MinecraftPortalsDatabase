using System.Collections.Generic;
using System.Linq;

namespace MinecraftPortalsDatabase
{
    class PortalsCollection : CollectionDatabaseObjects
    {
        public PortalsCollection(string worldName) : base($"PortalsCollection_{worldName}")
        {
            SetCollection(FileHandler.ReadArray<Portal>(FullPathFile));
        }

        public string GetStringNearestPortal(Dimension dimension, Point3 location) =>
            _collection.Select(x => x.Value as Portal).OrderBy(x => MathCustom.GetDistance(x.GetLocation(dimension), location)).First().ToString();

        public IEnumerable<string> GetColumn(ColumnNames columnName) =>
            _collection.Values.Select(x => x.ToDataGridViewRow()[(int)columnName].ToString());
    }
}
