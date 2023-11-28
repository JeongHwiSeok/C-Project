using System;
using System.IO;

namespace Class_14th
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 그래프
            #region 설명
            // 정점(vertex)과 간선(Edge)들이 서로 복잡하게 연결되어 있는 자료구조


            // 정점(vertex) :
            // 노드(node)라고도 하며, 데이터가 저장되는 그래프의 기본 원소

            // 간선(Edge) :
            // 링크(link)라고도 하며, 정점 간의 관계를 나타냄

            // 인접 정점(adgacent vertex) :
            // 하나의 정점에서 간선에 의해 직접 연결되어 있는 정점을 의미

            // 차수(Degree) :
            // 정점에 연결된 간선의 수를 의미

            // 진입 차수 : in - Degree
            // 외부에서 오는 간선의 수를 의미

            // 진출 차수 : out - Degree
            // 외부로 향하는 간선의 수를 의미

            // 사이클(Cycle) : 
            // 시작 정점과 종료 정점이 같은 단순 경로를 의미

            // 방향성 그래프 : 간선의 방향이 존재하는 그래프
            // 무방향 그래프 : 간선의 방향이 없이 연결만 되어있는 그래프
            // 가중치 그래프 : 간선에 일정한 정수 값이 포함되어있는 그래프
            #endregion

            #region 인접 행렬

            //int n = int.Parse(Console.ReadLine());
            //int count = 5;

            //AdjacencyMatrix<string> adjacencyMatrix = new AdjacencyMatrix<string>(n);

            //StreamReader sr = new StreamReader(Console.OpenStandardInput());
            //string[] vertexs = sr.ReadLine().Split(' ');

            //for(int i = 0; i < count; i++)
            //{
            //    string[] edge = sr.ReadLine().Split(' ');
            //    int x = int.Parse(edge[0]);
            //    int y = int.Parse(edge[1]);

            //    adjacencyMatrix.SetEdge(x, y);
            //}

            //adjacencyMatrix.Display();
            #endregion

            #region 인접 리스트

            #endregion

            #endregion
        }
    }
}
