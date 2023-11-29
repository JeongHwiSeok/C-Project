using System;
using System.IO;

namespace Class_15th
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BFS (너비 우선 탐색)
            AdjacencyList adjacencyList = new AdjacencyList(9);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);
            adjacencyList.InsertEdge(1, 2);
            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(2, 3);
            adjacencyList.InsertEdge(3, 4);
            adjacencyList.InsertEdge(4, 0);
            adjacencyList.InsertEdge(4, 1);
            adjacencyList.InsertEdge(4, 5);

            adjacencyList.BFS(0);

            #endregion
        }
    }
}
