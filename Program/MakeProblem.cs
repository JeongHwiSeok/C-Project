using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class MakeProblem
    {
        private string[] example = new string[5];
        private int[] count = new int[5];

        public MakeProblem()
        {
        }

        public void InputExample()
        {
            for (int i = 1; i < 5; i++)
            {
                example[i] = Console.ReadLine();
            }
        }

        private void Reset()
        {
            for(int i = 0; i < 5; i++)
            {
                count[i] = 0;
            }
        }

        public void View()
        {
            Random random = new Random();
            int randNum = 0;

            int i = 1;
            int solver = 0;
            while(i<5)
            {
                randNum = random.Next(1, 5);
                if(count[randNum] == 0)
                {
                    if(randNum == 1)
                    {
                        solver = i;
                    }
                    count[randNum]++;
                    Console.WriteLine(i + " : " + example[randNum]);
                    i++;
                }
            }
            Console.WriteLine("Solver : " + solver);
            Reset();
        }
    }
}
