using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5th
{
    class Wizard : Job
    {
        int attack = 100;

        // this와 base 키워드 중에서는 this 키워드의 우선 순위가 더 높음
        public Wizard() : base(100)
        {
            Console.WriteLine("attack : " + base.attack);
            Console.WriteLine("health : " + health);
        }
    }
}
