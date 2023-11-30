using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15th
{
    class AdjacencyList
    {
        private int size;
        private List<int>[] adjacencyList;
        
        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList = new List<int>[vertexSize];

            for(int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void InsertEdge(int vertex, int edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(i + " : ");
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + " -> ");
                }
                Console.WriteLine(" ");
            }
        }

        public void BFS(int start)
        {
            bool[] visited = new bool[size];

            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = true;

            while(q.Count > 0)
            {
                int now = q.Dequeue();
                Console.Write(now + " ");

                for(int i = 0; i < adjacencyList[now].Count; i++)
                {
                    if(visited[adjacencyList[now][i]] == false)
                    {
                        visited[adjacencyList[now][i]] = true;
                        q.Enqueue(adjacencyList[now][i]);
                    }
                }
            }
        }

        public void DFS(int root)
        {
            bool[] visited = new bool[size];

            #region 다른방법 - (visited 배열 처리 필요)
            visited[root] = true;

            Console.Write(root+ " ");

            foreach(int index in adjacencyList[root])
            {
                if(visited[index] == false)
                {
                    DFS(index);
                }
            }

            #endregion

            // DFSearch(visited, root);
        }

        //private void DFSearch(bool[] visited, int now)
        //{
        //    if(visited[now] == true)
        //    {
        //        return;
        //    }
        //    else if (adjacencyList[now].Count == 0)
        //    {
        //        Console.Write(now + " ");
        //        visited[now] = true;
        //        return;
        //    }
        //    else
        //    {
        //        Console.Write(now + " ");
        //        visited[now] = true;
        //        for(int i = 0; i < adjacencyList[now].Count; i++)
        //        {
        //            DFSearch(visited, adjacencyList[now][i]);
        //        }  
        //    }
        //}
    }
}
