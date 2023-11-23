using System;

namespace Class_12th
{
    class Program
    {
        static public int[] array = new int[9] { 5, 3, 8, 4, 9, 1, 6, 2, 7 };
        static void QuickSort(int[] array, int left, int right)
        {
            int low = left+1;
            int high = right-1;
            int pivot = left;
            while(low < high)
            {
                if(array[low] <= array[pivot])
                {
                    low++;
                }
                else
                {
                    if(array[high] >= array[pivot])
                    {
                        high--;
                    }
                    else
                    {
                        (array[low], array[high]) = (array[high], array[low]);
                        low++;
                        high--;
                    }
                }
            }
            (array[pivot], array[high]) = (array[high], array[pivot]);
            return high;
        }

        static void Main(string[] args)
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고 한 쪽에는 기준점보다 작은 항목들이 위치, 반대쪽에는 기준점 보다 큰 항목들이 위치

            // 나뉘어진 하위 배열에 대해 재귀적으로 퀵정렬을 호출하여 모든 배열이 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘

            // 시간 복잡도 : O(log n)
            #endregion

            
            // 배열의 첫번째를 pivot으로 지정
            // pivot을 제외한 나머지중 제일 좌측을 Left, 제일 우측을 Right로

            // Left와 pivot을 비교하여 pivot보다 작으면 우측으로 넘어감
            // Left와 pivot을 비교하여 pivot보다 크면 대기

            // Right와 pivot을 비교하여 pivot보다 크면 좌측으로 넘어감
            // Right와 pivot을 비교하여 pivot보다 작으면 대기

            // Right와 Left를 Swap

            // 이후 위의 작업을 반복

            // Left와 Right가 엇갈릴 경우 pivot과 Right를 Swap

            QuickSort(array, 0, 9);
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
