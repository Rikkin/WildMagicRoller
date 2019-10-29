using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class TableFactory
    {
        private static readonly List<WildMagic> _wildMagicTable = new List<WildMagic>();
        private static readonly List<WildMagic> _customWildMagicTable = new List<WildMagic>();

        static TableFactory()
        {
            _wildMagicTable.Add(new WildMagic(1, "This is effect placeholder number 1"));
            _wildMagicTable.Add(new WildMagic(2, "This is effect placeholder number 2"));
            _wildMagicTable.Add(new WildMagic(3, "This is effect placeholder number 3"));
            _wildMagicTable.Add(new WildMagic(4, "This is effect placeholder number 4"));
            _wildMagicTable.Add(new WildMagic(5, "This is effect placeholder number 5"));

            _customWildMagicTable.Add(new WildMagic(1, "This is custom effect placeholder number 1"));
            _customWildMagicTable.Add(new WildMagic(2, "This is custom effect placeholder number 2"));
            _customWildMagicTable.Add(new WildMagic(3, "This is custom effect placeholder number 3"));
            _customWildMagicTable.Add(new WildMagic(4, "This is custom effect placeholder number 4"));
            _customWildMagicTable.Add(new WildMagic(5, "This is custom effect placeholder number 5"));
        }

        
        public static WildMagic GetResult(int id)
        {
            return _wildMagicTable.FirstOrDefault(i => i.WildMagicID == id);
        }

        public static WildMagic GetCustomResult(int id)
        {
            return _customWildMagicTable.FirstOrDefault(i => i.WildMagicID == id);
        }
    }
}
