using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TeamDexLibrary
{
    public static class DataRetriever
    {
        public static List<Pokedex> pokedex()
        {
            string json = File.ReadAllText(@"");
            return JsonConvert.DeserializeObject<List<Pokedex>>(json);
        }
        public static List<Move> movedex()
        {
            string json = File.ReadAllText(@"./Json/move.json");
            return JsonConvert.DeserializeObject<List<Move>>(json);
        }
        public static List<Item> itemdex()
        {
            string json = File.ReadAllText(@"./Json/item.json");
            return JsonConvert.DeserializeObject<List<Item>>(json);
        }
        public static List<Ability> abilitydex()
        {
            string json = File.ReadAllText(@"./Json/ability.json");
            return JsonConvert.DeserializeObject<List<Ability>>(json);
        }
        public static List<Type> typedex()
        {
            string json = File.ReadAllText(@"./Json/type.json");
            return JsonConvert.DeserializeObject<List<Type>>(json);
        }
    }
}
