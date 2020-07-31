using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        class Result
        {
            public string vertices { get; set; }
            public int pathCost { get; set; }

            public Result()
            {
                this.vertices = String.Empty;
                this.pathCost = 0;
            }

        }
        class Graph
        {
            public List<int>[] vertex;


            public Graph(int noofVertices)
            {
                vertex = new List<int>[noofVertices];


                for (int i = 0; i < noofVertices; i++)
                {
                    vertex[i] = new List<int>();

                }


            }
        }

        

        static void AddEdges(Graph pgraph, int vertex, int Edge)
        {
            pgraph.vertex[vertex].Add(Edge);


        }

        static void DFS(Graph g, int pvertex, int startvertex, int[,] weightMatrix)
        {
            bool[] visited = new bool[g.vertex.Length];

            DFSNavigate(g, pvertex, visited, startvertex,weightMatrix);
        }

        static int k = 0;
        static Stack<int> storevertex = new Stack<int>();
        static Stack<int> storeEdgeWeight = new Stack<int>();
        static void DFSNavigate(Graph g, int vertex, bool[] visited, int startvertex, int[,] weightMatrix)
        {

            if (visited[vertex] != true)
            {
                k++;
                visited[vertex] = true;
                storevertex.Push(vertex);

                if(storevertex.Count > 1)
                {
                    int[] temparray = storevertex.ToArray();
                    int value = weightMatrix[temparray[1], temparray[0]];
                    storeEdgeWeight.Push(value);
                }
               
                
                //Console.WriteLine(vertex);

                if (k == g.vertex.Length)
                {
                    List<int> neighbours1 = g.vertex[vertex];

                    if (neighbours1.Contains(startvertex))
                    {
                        result_store[Resultindex] = new Result();
                        Console.WriteLine("Hamiltonian cycle exits:");
                        foreach (var obj in storevertex)
                        {
                            result_store[Resultindex].vertices += obj.ToString() + ',';
                            //Console.Write(obj);
                        }

                        Console.WriteLine("Path weight:");
                        foreach (var obj in storeEdgeWeight)
                        {
                            result_store[Resultindex].pathCost += obj;
                        }

                        Resultindex += 1;

                        visited[vertex] = false;
                        k--;
                        storevertex.Pop();
                        storeEdgeWeight.Pop();
                        return;
                    }


                }
            }

            List<int> neighbours = g.vertex[vertex];

            foreach (var v in neighbours)
            {
                if (visited[v] != true)
                    DFSNavigate(g, v, visited, startvertex,weightMatrix);

                if (v == neighbours.Last())
                {
                    visited[vertex] = false;
                    storevertex.Pop();
                    if(storeEdgeWeight.Count > 0)
                    storeEdgeWeight.Pop();
                    k--;
                }
            }
        }


        static void AddEdgeWeight(int[,]weightMatrix, int vertex, int Endvertex, int weight)
        {
            weightMatrix[vertex,Endvertex] = weight;
        }

        static Result[] result_store;
        static int Resultindex = 0;

        static void Main(string[] args)
        {

            Graph g = new Graph(3);
            int[,] weightatrix = new int[3, 3];

            result_store = new Result[3];
            

            AddEdges(g, 0, 1);
            AddEdgeWeight(weightatrix, 0, 1, 10);

            AddEdges(g, 0, 2);
            AddEdgeWeight(weightatrix, 0, 2, 2);

            AddEdges(g, 1, 0);
            AddEdgeWeight(weightatrix, 1, 0, 0);

            AddEdges(g, 1, 2);
            AddEdgeWeight(weightatrix, 1, 2, 2);

            AddEdges(g, 2, 0);
            AddEdgeWeight(weightatrix, 2, 0, 2);

            AddEdges(g, 2, 1);
            AddEdgeWeight(weightatrix, 2, 1, 2);

            DFS(g, 0, 0,weightatrix);

            Result shortestpath = null;

            foreach(var item in result_store)
            {
                if(item!= null)
                {
                    Console.WriteLine(item.vertices);
                    Console.WriteLine(item.pathCost);

                    if (shortestpath == null)
                    {
                        shortestpath = new Result();
                        shortestpath.vertices = item.vertices;
                        shortestpath.pathCost = item.pathCost;
                    }
                    else
                    {
                        if(shortestpath.pathCost > item.pathCost)
                        {
                            shortestpath.vertices = item.vertices;
                            shortestpath.pathCost = item.pathCost;
                        }
                    }



                }

            }

            Console.WriteLine("The shortest path is:");
            Console.WriteLine(shortestpath.vertices);
            Console.WriteLine(shortestpath.pathCost);

            Console.ReadLine();
        }

    }
}
