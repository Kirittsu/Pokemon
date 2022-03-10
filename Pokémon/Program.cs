using System;
using System.IO;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //make pokemon dictionary
            Dictionary<string, Pokémon> PkmnDic = new Dictionary<string, Pokémon>(3);
            for (int i = 0; i < pkmnlist.Count; i++)
            {
                JObject pkmnStats = pkmnlist[i].ToObject<JObject>();
                PkmnDic.Add(Convert.ToString(pkmnStats.SelectToken(name)), new Pokémon());
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Naam = Convert.ToString(pkmnStats.SelectToken(name));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].HP_Base = Convert.ToInt16(pkmnStats.SelectToken(hp));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Attack_Base = Convert.ToInt16(pkmnStats.SelectToken(attack));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Defense_Base = Convert.ToInt16(pkmnStats.SelectToken(defense));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].SpecialAttack_Base = Convert.ToInt16(pkmnStats.SelectToken(spAttack));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].SpecialDefense_Base = Convert.ToInt16(pkmnStats.SelectToken(spDefense));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Speed_Base = Convert.ToInt16(pkmnStats.SelectToken(speed));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Id = Convert.ToInt16(pkmnStats.SelectToken(id));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Number = Convert.ToInt16(pkmnStats.SelectToken(number));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Type[0] = Convert.ToString(pkmnStats.SelectToken(type[0]));
                PkmnDic[Convert.ToString(pkmnStats.SelectToken(name))].Type[1] = Convert.ToString(pkmnStats.SelectToken(type[1])); //"" if no second type*/
            }
        }
    }
}