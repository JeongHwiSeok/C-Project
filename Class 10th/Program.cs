using System;

namespace Class_10th
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 등차수열(과제)
            //int a1 = 1;
            //const int n = 10;
            //int d = 1;
            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += d;
            //}
            //a1 += sum;
            //Console.WriteLine(a1);
            //a1 = 1;
            //sum = 0;
            //int[] a = new int[n];
            //foreach (int element in a)
            //{
            //    sum += d;
            //}
            //a1 += sum;
            //Console.WriteLine(a1);
            #endregion

            #region 등차수열(수업)
            //int a; // 첫항
            //int d; // 공차
            //int n; // 횟수

            //// Console.ReadLine() : 기본적으로 string 타입으로만 값은 반환
            //// string name = Console.ReadLine();

            //// Console.WriteLine("name : " + name);

            //// Int32.Parse : int 타입으로 값을 반환
            //Console.Write("첫항 : ");
            //a = Int32.Parse(Console.ReadLine());

            //Console.Write("공차 : ");
            //d = Int32.Parse(Console.ReadLine());

            //Console.Write("횟수 : ");
            //n = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("a"+i + " : " + (a + d * i));
            //}
            #endregion

            #region 등비 수열
            //int a; // 첫항
            //int r; // 공비
            //int n; // n번째

            //Console.Write("첫항 : ");
            //a = Int32.Parse(Console.ReadLine());

            //Console.Write("공비 : ");
            //r = Int32.Parse(Console.ReadLine());

            //Console.Write("n번째 : ");
            //n = Int32.Parse(Console.ReadLine());

            //for(int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("a"+i+" : "+a);
            //    a *= r;
            //}

            #endregion

            #region 무명 형식
            // 이름이 존재하지 않는 객체 또는 변수를 의미

            // 무명 형식의 경우 값을 읽기만 할 수 있음
            //var data = new { Name = "Data", Value = 10 };

            //Console.WriteLine("Name : " + data.Name);
            //Console.WriteLine("Value : " + data.Value);
            #endregion
        }
    }
}
