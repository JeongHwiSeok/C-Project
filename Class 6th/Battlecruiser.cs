using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Battlecruiser : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("Battlecruiser Attack...");
        }

        public void Move()
        {
            Console.WriteLine("Battlecruiser Move...");
        }

        public void Skill()
        {
            Console.WriteLine("Battlecruiser Skill...");
        }
    }
}
