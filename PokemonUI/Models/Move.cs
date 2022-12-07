using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI.Models
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
    }
}
