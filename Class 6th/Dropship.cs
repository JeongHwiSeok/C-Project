using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Dropship : IMoveable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("Dropship Move...");
        }

        public void Skill()
        {
            Console.WriteLine("Dropship Skill...");
        }
    }
}
