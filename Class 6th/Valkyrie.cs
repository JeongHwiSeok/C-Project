using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Valkyrie : IMoveable, IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Valkyrie Attack...");
        }

        public void Move()
        {
            Console.WriteLine("Valkyrie Move...");
        }
    }
}
