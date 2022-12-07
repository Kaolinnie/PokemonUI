using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDexLibrary
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] DoubleDamage { get; set; }
        public int[] HalfDamage { get; set; }
        public int[] NoEffect { get; set; }

        public override string ToString()
        {
            string tmp = $"{Id}: {Name}";
            return tmp;
        }
    }
}
