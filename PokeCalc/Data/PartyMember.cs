using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokeCalc.Data
{
    public class PartyMember
    {
        public Pokemon pokemon { get; set; }
        public int partyIndex { get; set; }

        public PartyMember(Pokemon p, int i)
        {
            pokemon = p;
            partyIndex = i;
        }

        public PartyMember()
        {
            partyIndex = -2;
        }

        public PartyMember(int index)
        {
            partyIndex = index;
        }
    }
}
