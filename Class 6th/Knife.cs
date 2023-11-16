using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    class Knife : Weapon
    {
        public Knife() : base(5, 100, "Knife")
        {

        }

        public override void Action()
        {
            Console.WriteLine("Knife Attack");
        }
    }
}
