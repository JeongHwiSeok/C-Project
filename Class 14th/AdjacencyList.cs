using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14th
{
    class AdjacencyList<T>
    {
        private int size;
        private List<T>[] adjacencyList;
        private List<int>[] listArray;
        
        public AdjacencyList(int n)
        {
            size = n;
            adjacencyList = new List<T>[n];
            
        }

        public void InsertVertex(T data)
        {
            for (int i = 0; i < size; i++)
            {
                adjacencyList[i] = data + i;
            }
        }

        public void AddEdge(int x, int y)
        {

        }
    }
}
