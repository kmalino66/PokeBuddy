using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokeCalc.Data
{
    public class PokemonDataService
    {

        PokeApiClient pClient = new PokeApiClient();

        public PokemonDataService()
        {
            pClient = new PokeApiClient();
        }

        public async Task<Pokemon> GetPokemonAsync(string pokemonName)
        {
            var pokemon = await pClient.GetResourceAsync<Pokemon>(pokemonName);
            
            return pokemon;
        }
    }
}
