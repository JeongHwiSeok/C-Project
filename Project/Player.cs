using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4th
{
    public class Player
    {
        public void OnTriggerEnter(IItem item)
        {
            item.Use();
        }

        public void OnTimeTriggerEnter(IWaitTime waitTime)
        {
            waitTime.Wait(5.5f);
        }
    }
}
