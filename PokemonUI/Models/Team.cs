using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI.Models
{
    public class Team
    {
        public Pokemon[] PkmnTeam { get; set; }

        public Team()
        {
            PkmnTeam = new Pokemon[6];
        }


        public class Pokemon
        {
            public PokeApiNet.Pokemon Pkmn { get; set; }
            public NamedApiResource<Move>[] Moves { get; set; }
            public NamedApiResource<Item> HeldItem { get; set; }
            public NamedApiResource<Ability> Ability { get; set; }
            

            public override string ToString()
            {
                string pkmn = $"{Pkmn.Id}: {Pkmn.Name}\nAbility: {Ability.Name}";
                string moves = "\nMoves:\n";
                for(int i=0;i<Moves.Length;i++)
                {
                    moves += $"{i}) {Moves[i].Name}\n";
                }

                return pkmn + moves;
            }

        }
    }
}
