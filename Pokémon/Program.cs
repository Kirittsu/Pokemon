using System;
using System.IO;
using Newtonsoft.Json.Linq;


namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray ob1 = JArray.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../pokemon.json"));
            Newtonsoft.Json.Linq.JToken victreebell = new Newtonsoft.Json.Linq.JObject();
        }
    }
}