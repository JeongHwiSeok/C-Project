using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Wraith : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("Wraith Attack...");
        }

        public void Skill()
        {
            Console.WriteLine("Wraith Skill...");
        }

        public void Move()
        {
            Console.WriteLine("Wraith Move...");
        }
    }
}
