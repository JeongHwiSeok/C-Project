using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Mutalisk : AirUnit
    {
        public Mutalisk() : base(120, 9, 0)
        {

        }

        public override void AttackCommand()
        {
            Console.WriteLine("Zergling Attack");
        }

        public override void Fly()
        {
            Console.WriteLine("Zergling is AirUnit");
        }

        public override void Move()
        {
            Console.WriteLine("Zergling Move");
        }
    }
}
