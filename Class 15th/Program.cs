﻿using System;
using System.IO;

namespace Class_15th
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BFS (너비 우선 탐색)
            // root 노드에서 시작해서 인접한 노드를 먼저 탐색하는 방법
            //AdjacencyList adjacencyList = new AdjacencyList(9);

            //adjacencyList.InsertEdge(0, 1);
            //adjacencyList.InsertEdge(0, 2);
            //adjacencyList.InsertEdge(0, 7);
            //adjacencyList.InsertEdge(1, 4);
            //adjacencyList.InsertEdge(2, 3);
            //adjacencyList.InsertEdge(2, 4);
            //adjacencyList.InsertEdge(3, 5);
            //adjacencyList.InsertEdge(3, 6);
            //adjacencyList.InsertEdge(6, 7);

            //adjacencyList.BFS(0);

            #endregion

            #region DFS (깊이 우선 탐색)
            // root 노드에서 시작해서 다음 분기로 넘어가기 전에 해당 분기를 완벽하게 탐색하는 방법

            AdjacencyList adjacencyList = new AdjacencyList(7);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);
            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(1, 4);
            adjacencyList.InsertEdge(2, 5);
            adjacencyList.InsertEdge(2, 6);

            adjacencyList.DFS(0);

            #endregion
        }
    }
}
