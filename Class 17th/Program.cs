using System;

namespace Class_17th
{
    class Program
    {
        static void Hanoi(int n, char start, char end, char middle)
        {
            if(n == 1)
            {
                Console.WriteLine(n + "번째 원판 : " + start + " -> " + end);
            }
            else
            {
                Hanoi(n - 1, start, middle, end);
                Console.WriteLine(n + "번째 원판 : " + start + " -> " + end);
                Hanoi(n - 1, middle, end, start);
            }
        }

        static int Fibonacci(int n, int[] fibonacciMemory)
        {
            if (n <= 2)
            {
                return fibonacciMemory[n] = 1;
            }
            if (fibonacciMemory[n] > 0)
            {
                return fibonacciMemory[n];
            }
            return fibonacciMemory[n] = Fibonacci(n - 1, fibonacciMemory) + Fibonacci(n - 2, fibonacciMemory);
        }

        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해서 그것과 다른 범위까지의 값을 이용하여 효율적으로 값을 구하는 알고리즘

            // 메모이제이션
            // 프로그램이 동일한 연산을 반복해야 할 때, 이전 연산의 값을 메모리에 저장함으로써
            // 동일한 연산을 반복하는 작업을 제거하여 프로그램의 실행속도를 향상시키는 기법

            //int n = int.Parse(Console.ReadLine());

            //int[] fibonacciMemory = new int[n+1];

            //while (n != -1)
            //{
            //    if(fibonacciMemory.Length - 1 < n )
            //    {
            //        Array.Resize(ref fibonacciMemory, n + 1);
            //    }
            //    Console.WriteLine("피보나치 a" + n + " : " + Fibonacci(n, fibonacciMemory));

            //    n = int.Parse(Console.ReadLine());
            //}
            #endregion

            #region 하노이의 탑
            int n = int.Parse(Console.ReadLine());

            //int[] hanoiMemory = new int[n + 1];

            Hanoi(n, 'A', 'C', 'B');

            #endregion
        }
    }
}
