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
            String name = "$.name";
            string hp = "$.hp";
            string attack = "$.attack";
            string defense = "$.defense";
            string spAttack = "$.spAttack";
            string spDefense = "$.spDefense";
            string speed = "$.speed";
            string id = "$.id";
            string[] type = { "$.types[0]", "$.types[1]" };

            for (int i = 0; i < pkmnlist.Count; i++)
            {
                //
            }

            JObject pkmnStats = pkmnlist[0].ToObject<JObject>();

            Pokémon bulbasaur = new Pokémon();
            bulbasaur.Naam = Convert.ToString(pkmnStats.SelectToken(name));
            bulbasaur.HP_Base = Convert.ToString(pkmnStats.SelectToken(hp));
            bulbasaur.Attack_Base = Convert.ToString(pkmnStats.SelectToken(attack));
            bulbasaur.Defense_Base = Convert.ToString(pkmnStats.SelectToken(defense));
            bulbasaur.SpecialAttack_Base = Convert.ToString(pkmnStats.SelectToken(spAttack));
            //spdef, spe, id, number, types

        }
    }
}