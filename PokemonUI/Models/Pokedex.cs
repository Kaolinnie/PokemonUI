using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI.Models
{
    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Species_id { get; set; }
        public int Type_1 { get; set; }
        public int Type_2 { get; set; } = -1;
    }
}
