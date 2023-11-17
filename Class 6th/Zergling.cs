using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Zergling : GroundUnit
    {
        public Zergling() : base(35, 5, 0)
        {

        }

        public override void AttackCommand()
        {
            Console.WriteLine("Zergling Attack");
        }

        public override void Ground()
        {
            Console.WriteLine("Zergling is GroundUnit");
        }

        public override void Move()
        {
            Console.WriteLine("Zergling Move");
        }
    }
}
