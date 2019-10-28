using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class WildMagic
    {
        public int WildMagicID { get; }
        public string WildMagicEffect { get; }

        public WildMagic(int id, string effect)
        {
            WildMagicID = id;
            WildMagicEffect = effect;
        }
    }
}
