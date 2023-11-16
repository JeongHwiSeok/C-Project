using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Rifle : Weapon
    {
        public Rifle() : base(25, 100, "Rifle")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Rifle Attack");
        }
    }
}
