using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDexLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dex = DataRetriever.pokedex();
            foreach(var b in dex)
            {
                Console.WriteLine(b);
            }
        }
    }
}
