using System;

namespace Second_Class
{

    public class Item
    {
        private int price;
        public string name;

        public void View()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("price : " + price);
        }
    }

    public class Vector3
    {
        // ref : 하나의 변수에 서로 다른 이름으로 사용할 수 있는 키워드
        public void Distance(ref int x)
        {
            x = 100;
        }
        // In : 읽기 전용으로 적용되며, 참조로 전달하는 키워드
        public void Lerp(in int x)
        {
            Console.WriteLine("x : " + x);
        }
        // Out : 출력용 매개 변수로 함수 내에서 값을 반드시 초기화해야함
        public void MoveTowards(out int x)
        {
            x = 999;
        }
        // Params : 가변 길이 매개변수
        public void Normalize(params object[] list)
        {
            object sum;
            for (int i = 0; i < list.Length; i++)
            {
                sum = list[i];
                Console.Write(sum + " ");
            }
            Console.WriteLine("");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            #region 가비지 컬렉터
            // 동적으로 할당된 메모리 영역 가운데 더 이상 사용하지 않는 가비지를 모아 압축하여 다시 사용가능하게 만드는 것
            #endregion

            #region 매개변수 한정자

            int x = 0;

            Vector3 vector3 = new Vector3();

            // ref
            /* 
            // vector3.Distance(ref x);
            // Console.WriteLine("x : " + x);
            */

            // In
            // vector3.Lerp(x);

            // Out
            //vector3.MoveTowards(out x);

            //Console.WriteLine("x : " + x);

            // Params
            //vector3.Normalize(1, 2, 3, 4, 5);
            //vector3.Normalize('A','B','C','D','E');

            #endregion
        }

    }
}
