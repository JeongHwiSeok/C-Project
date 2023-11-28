using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_14th
{

    class AdjacencyMatrix<T>
    {
        private int size;
        private T[] vertex;
        private int[,] matrix;

        public AdjacencyMatrix(int n)
        {
            size = n;
            vertex = new T[n];
            matrix = new int[n + 1, n + 1];
        }

        public void InsertVertex(T data)
        {
            for(int i = 0; i < size; i++)
            {
                vertex[i] = data;
            }
        }

        public void SetEdge(int x, int y)
        {
            matrix[x, y] = 1;
            matrix[y, x] = 1;
        }

        public void Display()
        {
            for (int i = 0; i <= size; i++)
            {
                if(i == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write(vertex[i-1]);
                }
                for (int j = 0; j <= size; j++)
                {
                    if( i == 0 )
                    {
                        if( j != 0 )
                        {
                            Console.Write(vertex[j-1]);
                        }
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
