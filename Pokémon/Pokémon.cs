using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon
{
    class Pokémon
    {
        //private variable
        private int hp;
        private int attackBase;
        private int defenseBase;
        private int specialAttackBase;
        private int specialDefenseBase;
        private int speedBase;
        private int level;
        private string[] type = {null, null};
        private int id;
        private string naam;
        private int number;


        //constructor
        public Pokémon(string naamConstructor, int hpConstructor, int attackBaseConstructor, int defenseBaseConstructor, int specialAttackBaseConstructor, int specialDefenseBaseConstructor, int speedbaseConstructor, int idConstructor, int numberConstructor, string typeConstructor1, string typeConstructor2)
        {
            naam = naamConstructor;
            hp = hpConstructor;
            attackBase = attackBaseConstructor;     
            defenseBase = defenseBaseConstructor;   
            specialAttackBase = specialAttackBaseConstructor;
            specialDefenseBase = specialDefenseBaseConstructor;
            speedBase = speedbaseConstructor;
            id = idConstructor;
            number = numberConstructor;
            type[0] = typeConstructor1;
            type[1] = typeConstructor2; //"" if no second type*/
        }



        //properties
        public int HP_Base
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Attack_Base
        {
            get { return attackBase; }
            set { attackBase = value; }
        }
        public int Defense_Base
        {
            get { return defenseBase; }
            set { defenseBase = value; }
        }
        public int SpecialAttack_Base
        {
            get { return specialAttackBase; }
            set { specialAttackBase = value; }
        }
        public int SpecialDefense_Base
        {
            get { return specialDefenseBase; }
            set { specialDefenseBase = value; }
        }
        public int Speed_Base
        {
            get { return speedBase; }
            set { speedBase = value; }
        }
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }
        public double Average
        {
            get
            {
                return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6;
            }
        }
        public int Total
        {
            get { return HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base; }
        }

        
        public string[] Type 
        {
            get { return type; } 
            set { type = value; } 
        }


        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int HP_Full
        {
            get { return (((HP_Base + 50) * Level) / 50) + 10; }
        }

        public int Attack_Full
        {
            get { return ((Attack_Base * Level) / 50) + 5; }
        }

        public int Defense_Full
        {
            get { return ((Defense_Base * Level) / 50) + 5; }

        }

        public int SpecialAttack_Full
        {
            get { return ((SpecialAttack_Base * Level) / 50) + 5; }
        }

        public int SpecialDefense_Full
        {
            get { return ((SpecialDefense_Base * Level) / 50) + 5; }
        }

        public int Speed_Full
        {
            get { return ((Speed_Base * Level) / 50) + 5; }
        }
    }
}
