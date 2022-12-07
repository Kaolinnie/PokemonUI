using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Double_Damage { get; set; }
        public int[] Half_Damage { get; set; }
        public int[] No_Damage { get; set; }
    }
}
