﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14th
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
    }
}
