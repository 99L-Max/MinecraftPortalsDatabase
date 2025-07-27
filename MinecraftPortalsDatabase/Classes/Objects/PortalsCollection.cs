using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    class PortalsCollection : DataSaving
    {
        private readonly Dictionary<string, Portal> _portals;

        public PortalsCollection() : base(FileHandler.PathLocalAppData, "PortalsCollection")
        {
            var array = FileHandler.ReadPortals(FullPathFile);
            _portals = array != null ? array.ToDictionary(k => k.Name, v => v) : new Dictionary<string, Portal>();
        }

        public bool IsEmpty =>
            _portals.Count == 0;

        public bool Add(Portal portal)
        {
            if (portal.Name == string.Empty)
            {
                MessageBox.Show($"The portal name is not specified.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_portals.ContainsKey(portal.Name))
            {
                MessageBox.Show($"A portal with the name '{portal.Name}' already exists in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _portals.Add(portal.Name, portal);
            return true;
        }

        public bool Remove(string name) =>
            _portals.Remove(name);

        public bool Replace(string nameOldPortal, Portal newPortal)
        {
            if (!_portals.ContainsKey(nameOldPortal)) return false;

            if (nameOldPortal == newPortal.Name)
            {
                _portals[nameOldPortal] = newPortal;
                return true;
            }

            if (Add(newPortal))
            {
                _portals.Remove(nameOldPortal);
                return true;
            }

            return false;
        }

        public string GetStringNearestPortal(Dimension dimension, Point3 location) =>
            _portals.OrderBy(x => MathCustom.GetDistance(x.Value.GetLocation(dimension), location)).FirstOrDefault().Value.ToString();

        public object[][] ToDataGridView() =>
            _portals.Values.Select(x => x.ToDataGridViewRow()).ToArray();

        public Portal GetCopyPortal(string name) =>
            _portals[name].GetCopy();

        public override void Save() =>
            Save(_portals.Values);
    }
}
