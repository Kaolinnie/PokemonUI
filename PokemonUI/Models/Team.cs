using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string Description { get; set; } = "Random Team";
        public Pokemon[] Members { get; set; } = new Pokemon[6];

        public class Pokemon
        {
            public Pokedex Species { get; set; }
            public Item HeldItem { get; set; }
            public Move[] Moves { get; set; } = new Move[4];
            public Ability Ability { get; set; }
        }
    }
}
