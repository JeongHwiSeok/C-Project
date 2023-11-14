using System;

namespace Class_5th
{
    public delegate void Calculater(int x, int y);
    class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine("x + y = " + (x + y));
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine("x - y = " + (x - y));
        }

        static void Multiple(int x, int y)
        {
            Console.WriteLine("x * y = " + (x * y));
        }

        static void Devide(int x, int y)
        {
            Console.WriteLine("x / y = " + (x / y));
        }

        static void Main(string[] args)
        {
            Calculater calculater;
            #region 델리게이트
            //calculater = Add;

            //calculater(20, 10);

            //calculater = Substract;

            //calculater(20, 10);

            //calculater = Multiple;

            //calculater(20, 10);

            //calculater = Devide;

            //calculater(20, 10);
            #endregion

            #region 델리게이트 체인
            //calculater = Add;

            //calculater += Substract;

            //calculater += Multiple;

            //calculater += Devide;

            //calculater(15, 5);
            #endregion

            #region Resolution

            // readonly 런타임 상수

            // const 컴파일 상수

            #endregion

            #region Base 키워드

            Wizard wizard = new Wizard();

            #endregion

        }
    }
}
