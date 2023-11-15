using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Ghost Move");
        }
        public override void Attack()
        {
            Console.WriteLine("Ghost Attack");
        }
    }
}
