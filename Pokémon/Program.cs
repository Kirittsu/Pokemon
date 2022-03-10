using System;
using System.IO;
using Newtonsoft.Json.Linq;


namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject ob1 = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../pokemon.json"));
        }
    }
}
