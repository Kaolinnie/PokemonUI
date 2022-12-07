using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDexLibrary
{
    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Types { get; set; }

        public override string ToString()
        {
            var tmp = $"{Id}: {Name}\n";
            var types = "";
            foreach (var type in Types)
            {
                types += " " + type;
            }
            return tmp + types;
        }
    }
}
