using System;

namespace Class_11th
{
    class Program
    {
        const int size = 10;
        static int[] array = new int[size] {6,5,11,13,27,55,66,10,28,7};

        static void BinarySearch(int middle, int search)
        {
            Array.Sort(array); // 배열을  오름차순으로 정렬하는 함수
            #region 과제
            //if (array[middle] == search)
            //{
            //    Console.WriteLine(search + "는 " + middle + "번째 입니다.");
            //}
            //else if (array[middle] > search)
            //{
            //    if (array[middle - 1] < search && middle > 0)
            //    {
            //        Console.WriteLine("값이 존재하지 않습니다");
            //    }
            //    else if (array[0] > search)
            //    {
            //        Console.WriteLine("값이 존재하지 않습니다");
            //    }
            //    else
            //    {
            //        high = middle;
            //        middle = (low + high) / 2;
            //        BinarySearch(middle, search);
            //    }
            //}
            //else
            //{
            //    if (array[middle + 1] > search && middle < size - 1)
            //    {
            //        Console.WriteLine("값이 존재하지 않습니다");
            //    }
            //    else if (array[size - 1] < search)
            //    {
            //        Console.WriteLine("값이 존재하지 않습니다");
            //    }
            //    else
            //    {
            //        low = middle;
            //        middle = (low + high) / 2;
            //        BinarySearch(middle, search);
            //    }
            //}
            //low = 0;
            //high = size;
            #endregion
            #region 수업
            int low = 0;
            int high = size - 1;
            while (low <= high)
            {
                middle = (low + high) / 2;

                if (array[middle] == search)
                {
                    Console.WriteLine("array[middle] : " + array[middle]);
                    return;
                }
                else if (array[middle] > search)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            Console.WriteLine("Not value Found");
            #endregion
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
