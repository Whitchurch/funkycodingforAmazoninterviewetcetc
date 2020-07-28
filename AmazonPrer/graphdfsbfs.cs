using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        class Graph
        {
            public List<int>[] vertices { get; set; }
            
            public Graph(int noOfVertices)
            {
                //Create a list, to represent each vertex.
               
                vertices = new List<int>[noOfVertices];
                
                //Create a list per vertex. This is used to store the edges which represent which neighbouring vertex
                //Out current vertex connects to.

                for(int i = 0; i < vertices.Length; i++)
                {
                    vertices[i] = new List<int>();
                }

            }
        }

        static void addEdge(Graph g,int vertices, int edgeinfo)
        {
            g.vertices[vertices].Add(edgeinfo);
        }

        static void DFSnavigate(Graph g, bool[] visibility, int vertex)
        {
            visibility[vertex] = true;
            Console.WriteLine(vertex);

            List<int> neighbourveritces = g.vertices[vertex];

            foreach(var v in neighbourveritces)
            {
                if (visibility[v] != true)
                    DFSnavigate(g, visibility, v);

            }
        }

        static void DFS(Graph g,int vertex)
        {
            bool[] visibility = new bool[g.vertices.Length];
            DFSnavigate(g, visibility, vertex);


        }


        static Queue<int> vertexToExplore = new Queue<int>();

        static void BFSnavigate(Graph g, bool[] visibility, int vertex)
        {
            if (visibility[vertex] != true)
            {
                visibility[vertex] = true;
                Console.WriteLine(vertex);
            }
                
            List<int> neighbours = g.vertices[vertex];
           
            foreach(var v in neighbours)
            {
                if(visibility[v] != true)
                {
                    visibility[v] = true;
                    Console.WriteLine(v);
                    vertexToExplore.Enqueue(v);
                }

            }

            while(vertexToExplore.Count > 0)
            {
                int nextVertex = vertexToExplore.Dequeue();
                BFSnavigate(g, visibility, nextVertex);
            }

        }

        static void BFS(Graph g, int vertex)
        {
            bool[] visibility = new bool[g.vertices.Length];
            BFSnavigate(g, visibility, vertex);
        }

        static void Main(string[] args)
        {
            Graph g = new Graph(4);
            addEdge(g, 0, 1);
            addEdge(g, 0, 2);
            addEdge(g, 1, 2);
            addEdge(g, 2, 0);
            addEdge(g, 2, 3);
            addEdge(g, 3, 3);

            DFS(g,2);
            BFS(g, 2);

            Console.ReadLine();
        }

    }
}
