using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    public abstract class Weapon
    {
        protected int attack;
        protected int durability;
        protected string name;


        public Weapon(int attack, int durability, string name)
        {
            this.attack = attack;
            this.durability = durability;
            this.name = name;
        }
        public int Attack
        {
            get
            {
                return attack;
            }
        }

        public int Durability
        {
            get
            {
                return durability;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public abstract void Action();
    }
}
