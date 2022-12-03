using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokemonUI
{
    public class PokemonEntry
    {
        PokemonFull[] teamMembers;

        public PokemonEntry() {
            teamMembers = new PokemonFull[6];
            generatePokemon();
        }
        public async void getPokemon()
        {
            PokeApiClient c = new PokeApiClient();
            NamedApiResourceList<Pokemon> pokemonList = await c.GetNamedResourcePageAsync<Pokemon>(1154, 0);
            //implement function if u want

        }

        public async void generatePokemon()
        {
            PokeApiClient c = new PokeApiClient();

            int numberToGenerate = 6;
            for (int i = 0; i < numberToGenerate; i++)
            {
                Random random = new Random();
                var randomPokemom = random.Next(0, 1154);
                Pokemon p = await c.GetResourceAsync<Pokemon>(randomPokemom);
                PokemonFull[i] = new PokemonFull(p.Name, p.Sprites.FrontDefault);
            }
        }
        private class PokemonFull
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public PokemonFull (string name, string imageurl)
            {
                Name = name;
                ImageUrl = imageurl;
            }
        }
    }
}
