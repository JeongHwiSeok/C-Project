using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4th
{
    public abstract class Unit
    {
        int health;
        int attack;
        int defence;

        public virtual void Information()
        {
            Console.WriteLine("Health : " + health);
            Console.WriteLine("Attack : " + attack);
            Console.WriteLine("Defence : " + defence);
        }

        public abstract void Skill();
    }
}
