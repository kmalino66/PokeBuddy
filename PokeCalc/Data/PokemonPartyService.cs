using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokeCalc.Data
{
    public class PokemonPartyService
    {
        public PartyMember enemyPokemon = new PartyMember();
        public List<PartyMember> partyPokemon = new List<PartyMember>();

        public int AddPokemon(Pokemon poke)
        {
            partyPokemon.Add(new PartyMember(poke, partyPokemon.Count));
            return partyPokemon.Count - 1;
        }

        public void RemovePokemon(int index)
        {
            partyPokemon.RemoveAt(index);
        }

        public void UpdatePokemon(PartyMember newMember)
        {
            if (newMember.partyIndex == -1)
            {
                if (enemyPokemon == null)
                {
                    enemyPokemon = new PartyMember(newMember.pokemon, -1);
                }
                else
                {
                    enemyPokemon.pokemon = newMember.pokemon;
                }
            }
            else
            {
                partyPokemon.ElementAt<PartyMember>(newMember.partyIndex).pokemon = newMember.pokemon;
            }
        }

        public void UpdateEnemy(Pokemon newPokemon)
        {
            enemyPokemon.pokemon = newPokemon;
        }

        public PartyMember GetPartyI(int i)
        {
            return partyPokemon.ElementAt<PartyMember>(i);
        }
    }
}
