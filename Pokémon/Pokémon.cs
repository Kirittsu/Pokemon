using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon
{
    class Pokémon
    {
        //private variable
        private int hp = 0;
        private int attackBase = 0;
        private int defenseBase = 0;
        private int specialAttackBase = 0;
        private int specialDefenseBase = 0;
        private int speedBase = 0;
        private int level = 50;
        private string[] type = {null, null};
        private int id = 0;
        private string naam = "";
        private int number = 0;


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

        //Methods
        static public object Battle(Pokémon pkmn1, Pokémon pkmn2)
        {
            int currentPkmn = 0;
            int attack1 = 0;
            int attack2 = 0;
            int defense1 = 0;
            int defense2 = 0;
            int hp1 = pkmn1.HP_Full;
            int hp2 = pkmn2.HP_Full;

            if (pkmn1.Speed_Full > pkmn2.Speed_Full)
            {
                currentPkmn = 1;
            }else
            {
                currentPkmn = 2;
            }

            if (pkmn1.Attack_Full > pkmn1.SpecialAttack_Full)
            {
                attack1 = pkmn1.Attack_Full;
                defense2 = pkmn2.Defense_Full;
            }else
            {
                attack1 = pkmn1.SpecialAttack_Full;
                defense2 = pkmn2.SpecialDefense_Full;
            }
            
            if (pkmn2.Attack_Full > pkmn2.SpecialAttack_Full)
            {
                attack2 = pkmn2.Attack_Full;
                defense1 = pkmn1.Defense_Full;
            }else
            {
                attack2 = pkmn2.SpecialAttack_Full;
                defense1 = pkmn1.SpecialDefense_Full;
            }

            while ((hp1 >= 0) && (hp2 >= 0))
            {
                if (currentPkmn == 1)
                {
                    currentPkmn = 2;
                    hp2 =- (attack1 - defense2);
                }else
                {
                    currentPkmn = 1;
                    hp1 =- (attack2 - defense1);
                }
            }

            if (hp1 > hp2)
                return pkmn1.Naam;
            
            else
                return pkmn2.Naam;
        }
    }
}
