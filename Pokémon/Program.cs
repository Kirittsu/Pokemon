using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Json configuration
            JArray pkmnlist = JArray.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../pokemon.json"));
            String name = "$.name";
            string hp = "$.hp";
            string attack = "$.attack";
            string defense = "$.defense";
            string spAttack = "$.spAttack";
            string spDefense = "$.spDefense";
            string speed = "$.speed";
            string id = "$.id";
            string number = "$.number";
            string[] type = { "$.types[0]", "$.types[1]" };

            //make pokemon objects
            for (int i = 0; i < pkmnlist.Count; i++)
            {
                //
            }

            //template for loop
            JObject pkmnStats = pkmnlist[5].ToObject<JObject>();

            Pokémon bulbasaur = new Pokémon();

            bulbasaur.Naam = Convert.ToString(pkmnStats.SelectToken(name));
            bulbasaur.HP_Base = Convert.ToInt16(pkmnStats.SelectToken(hp));
            bulbasaur.Attack_Base = Convert.ToInt16(pkmnStats.SelectToken(attack));
            bulbasaur.Defense_Base = Convert.ToInt16(pkmnStats.SelectToken(defense));
            bulbasaur.SpecialAttack_Base = Convert.ToInt16(pkmnStats.SelectToken(spAttack));
            bulbasaur.SpecialDefense_Base = Convert.ToInt16(pkmnStats.SelectToken(spDefense));
            bulbasaur.Speed_Base = Convert.ToInt16(pkmnStats.SelectToken(speed));
            bulbasaur.Id = Convert.ToInt16(pkmnStats.SelectToken(id));
            bulbasaur.Number = Convert.ToInt16(pkmnStats.SelectToken(number));
            bulbasaur.Type[0] = Convert.ToString(pkmnStats.SelectToken(type[0]));
            bulbasaur.Type[1] = Convert.ToString(pkmnStats.SelectToken(type[1])); //"" if no second type
        }
    }
}