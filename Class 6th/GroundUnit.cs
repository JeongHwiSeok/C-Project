using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
     public abstract class GroundUnit : Zerg
    {
        public GroundUnit(int health, int attack, int depence)
        {
            this.health = health;
            this.attack = attack;
            this.depence = depence;
        }

        public abstract void Ground();
    }
}
