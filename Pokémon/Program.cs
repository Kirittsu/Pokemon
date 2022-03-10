using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray pkmnlist = JArray.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../pokemon.json"));

            for (int i = 0; i < pkmnlist.Count; i++)
            {
                //JObject pkmnName = pkmnlist[].ToObject<JObject>();
            }           
            
            JObject Ivysaur = pkmnlist[1].ToObject<JObject>();
            Console.WriteLine(Ivysaur);
        }
    }
}