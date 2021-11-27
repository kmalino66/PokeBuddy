using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeCalc.Data
{
    public class PartyMemberAction
    {
        public PartyMember member { get; set; }
        public PartyMemberActionEnum action { get; set; }

        public PartyMemberAction(PartyMember m, PartyMemberActionEnum a)
        {
            member = m;
            action = a;
        }

    }

    public enum PartyMemberActionEnum
    {
        Add,
        Remove,
        Modify,
        SetEnemy
    }
}
