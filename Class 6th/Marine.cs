using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Marine Move");
        }
        public override void Attack()
        {
            Console.WriteLine("Marine Attack");
        }
    }
}
