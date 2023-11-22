using System;

namespace Class_11th
{
    class Program
    {
        const int size = 10;
        static int low = 0;
        static int high = size;
        static int[] array = new int[size] {10,20,30,40,50,60,70,80,90,100};

        static void BinarySearch(int middle, int search)
        {
            if(array[middle] == search)
            {
                Console.WriteLine(search + "는 " + middle + "번째 입니다.");
            }
            else if(array[middle] > search)
            {
                if(array[middle-1] < search && middle > 0)
                {
                    Console.WriteLine("값이 존재하지 않습니다");
                }
                else if(array[0] > search)
                {
                    Console.WriteLine("값이 존재하지 않습니다");
                }
                else
                {
                    high = middle;
                    middle = (low + high) / 2;
                    BinarySearch(middle, search);
                }
            }
            else
            {
                if(array[middle+1] > search && middle < size-1)
                {
                    Console.WriteLine("값이 존재하지 않습니다");
                }
                else if(array[size-1] < search)
                {
                    Console.WriteLine("값이 존재하지 않습니다");
                }
                else
                {
                    low = middle;
                    middle = (low + high) / 2;
                    BinarySearch(middle, search);
                }
            }
            low = 0;
            high = size;
        }

        static void Main(string[] args)
        {
            #region 이진 탐색
            // 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘

            // 처음 중간의 값을 임의의 값으로 선택하여 그 값과 찾고자 하는 값의 차이에 따라
            // 우측과 좌측을 선택하여 선택된 부분에서 다시 중간값을 찾아 앞의 방식을 반복

            int n = Int32.Parse(Console.ReadLine());

            while(n != -1)
            {
                BinarySearch(size / 2, n);
                n = Int32.Parse(Console.ReadLine());
            }
            

            #endregion
        }
    }
}
