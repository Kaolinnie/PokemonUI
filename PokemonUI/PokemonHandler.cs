using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokeApiNet;
using PokemonUI.Models;

namespace PokemonUI
{
    public static class PokemonHandler
    {

        public static PokeApiClient client = new PokeApiClient();
        public static async Task<NamedApiResourceList<Pokemon>> GetPokemon()
        {
            NamedApiResourceList<Pokemon> pokemonList = await client.GetNamedResourcePageAsync<Pokemon>(1154, 0);
            return pokemonList;
        }


        public static async Task<NamedApiResource<Item>> RandomItem()
        {
            try
            {
                NamedApiResourceList<Item> items = await client.GetNamedResourcePageAsync<Item>(10000, 0);
                Random ran = new Random();
                return items.Results.ElementAt(ran.Next(0, items.Results.Count));
            } catch (HttpRequestException)
            {
                await Task.Delay(100);
                return await RandomItem();
            }
            
        }
        public static NamedApiResource<Move>[] RandomMoves(Pokemon p)
        {
            Random ran = new Random();

            NamedApiResource<Move>[] moves = new NamedApiResource<Move>[4];

            int numOfMoves = ran.Next(1, 4);
            for (int i = 0; i < numOfMoves; i++)
            {
                NamedApiResource<Move> move = null;
                while (move == null || moves.Contains(move))
                {
                    move = p.Moves.ElementAt(ran.Next(0, p.Moves.Count)).Move;
                    moves[i] = move;
                }
            }
            return moves;
        }
        public static async Task<Pokemon> RandomPokemon()
        {
            try { 
                Random ran = new Random();
                Pokemon pkmn = await client.GetResourceAsync<Pokemon>(ran.Next(0, 1100));
                return pkmn;
            } catch (HttpRequestException)
            {
                await Task.Delay(1000);
                return await RandomPokemon();
            }
        }
        public static async Task<NamedApiResource<Nature>> RandomNature()
        {
            try { 
                NamedApiResourceList<Nature> natures = await client.GetNamedResourcePageAsync<Nature>(10000, 0);
                Random ran = new Random();
                return natures.Results.ElementAt(ran.Next(0, natures.Results.Count));
            }
            catch (HttpRequestException)
            {
                await Task.Delay(100);
                return await RandomNature();
            }
        }
    }
}
