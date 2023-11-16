using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Axe : Weapon
    {
        public Axe() : base(10, 100, "Axe")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Axe Attack");
        }
    }
}
