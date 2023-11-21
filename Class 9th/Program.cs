using System;
using System.Collections;

namespace Class_9th
{
    public class Rifle : IEnumerator
    {
        private int index;
        private int[] bullet;
        
        public Rifle()
        {
            index = -1;
            bullet = new int[5];
        }
        // Current : 읽기 전용 프로퍼티로 현재 위치의 데이터를 object 타입으로 반환
        public object Current
        {
            get
            {
                return bullet[index];
            }
        }

        // MoveNext() : 다음 위치로 이동하는데 배열이 존재 한다면 True, 없다면 False를 반환하는 함수
        public bool MoveNext()
        {
            index++;
            if (index < bullet.Length)
            {
                return (bullet[index] != null);
            }
            else
            {
                Reset();
                return false;
            }
        }

        // Reset() : 인덱스를 초기 상태로 이동시킴. 컬렉션의 인덱스를 -1로 설정
        public void Reset()
        {
            index = -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 예외 처리
            //try
            //{
            //    int data = 0;

            //    Console.WriteLine(100 / data);
            //}
            //catch (DivideByZeroException error)
            //{
            //    Console.WriteLine(error.Message);
            //}

            #endregion

            #region 열거자
            //Rifle rifle = new Rifle();

            //while(rifle.MoveNext())
            //{
            //    Console.WriteLine(rifle.Current);
            //}
            #endregion

            #region 

            #endregion
        }
    }
}
