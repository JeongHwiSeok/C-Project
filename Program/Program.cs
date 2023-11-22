using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("필요 작업을 선택하십시오.");
            Console.WriteLine("");
            Console.WriteLine("1. 문제 단어 선택");
            Console.WriteLine("2. 문제 보기 생성");
            
            Number = Int32.Parse(Console.ReadLine());
            if(Number == 1)
            {
                Random random = new Random();
                int n;
                Console.WriteLine("단어의 총 갯수를 입력하십시오.");
                n = Int32.Parse(Console.ReadLine());
                int[] a = new int[n + 1];

                Console.WriteLine("단어 묶음이 2개면 K값을 입력하십시오.");
                Console.WriteLine("그렇지 않다면 0을 입력하십시오");
                int k;

                Console.Write("K : ");
                k = Int32.Parse(Console.ReadLine());

                int i = 0;
                while (i < 10)
                {
                    int rand = random.Next(1, n + 1);
                    if (k == 0)
                    {
                        if (a[rand] == 0)
                        {
                            a[rand]++;
                            Console.WriteLine(rand);
                            i++;
                        }
                    }
                    else
                    {
                        if (i < 5)
                        {
                            rand = random.Next(1, k + 1);
                            if (a[rand] == 0)
                            {
                                a[rand]++;
                                Console.WriteLine(rand);
                                i++;
                            }
                        }
                        else
                        {
                            rand = random.Next(k + 1, n + 1);
                            if (a[rand] == 0)
                            {
                                a[rand]++;
                                Console.WriteLine(rand);
                                i++;
                            }
                        }

                    }
                }
            }
            else
            {
                MakeProblem makeProblem = new MakeProblem();
                int count = 1;
                while(count <11)
                {
                    Console.WriteLine("문제 보기를 입력하십시오");
                    makeProblem.InputExample();
                    makeProblem.View();
                    count++;
                }
            }
        }
    }
}
