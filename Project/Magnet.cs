using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4th
{
    public class Magnet : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Magnet");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("Wait time : " + timer);
        }
    }
}
