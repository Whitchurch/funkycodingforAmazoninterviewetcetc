using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        class node
        {
            public int vertex { get; set; }
            public int vertexweight { get; set; }

            public node(int pvertex, int pvertexweight)
            {
                this.vertex = pvertex;
                this.vertexweight = pvertexweight;
            }

        }

    /*    class Graph
        {
            public List<int>[] vertex;
            public List<int>[] vertexWeight;

            public Graph(int noofVertices)
            {
                vertex = new List<int>[noofVertices];
                vertexWeight = new List<int>[noofVertices];

                for (int i = 0; i < noofVertices; i++)
                {
                    vertex[i] = new List<int>();
                    vertexWeight[i] = new List<int>();
                }
                   

            }
        }*/

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

     /*   static void AddEdges(Graph pgraph,int vertex, int Edge, int EdgeWeight)
        {
            pgraph.vertex[vertex].Add(Edge);
            pgraph.vertexWeight[vertex].Add(EdgeWeight);

        }*/


        static void DFS(Graph g, int pvertex, int startvertex)
        {
            bool[] visited = new bool[g.vertex.Length];

            DFSNavigate(g, pvertex, visited,startvertex);
        }

        static int k = 0;
        static Stack<int> storevertex = new Stack<int>();
        static void DFSNavigate(Graph g, int vertex, bool[] visited, int startvertex)
        {

            if(visited[vertex]!= true)
            {
                k++;
                visited[vertex] = true;
                storevertex.Push(vertex);
                //Console.WriteLine(vertex);

                if(k == g.vertex.Length)
                {
                    List<int> neighbours1 = g.vertex[vertex];

                   if( neighbours1.Contains(startvertex))
                    {
                        Console.WriteLine("Hamiltonian cycle exits");
                        foreach(var obj in storevertex)
                        {
                            Console.WriteLine(obj);
                        }

                        visited[vertex] = false;
                        k--;
                        storevertex.Pop();
                        return;
                    }

                    
                }
            }

            List<int> neighbours = g.vertex[vertex];

            foreach(var v in neighbours)
            {
                if(visited[v]!= true)
                DFSNavigate(g, v, visited,startvertex);

                if (v == neighbours.Last())
                {
                    visited[vertex] = false;
                    storevertex.Pop();
                    k--;
                }
            }
        }


        static int sumGraph(Graph g, int pvertex)
        {
            int sum = 0;
            bool[] visited = new bool[g.vertex.Length];

            sum = SumPathCost(g, pvertex, visited,sum,pvertex);

            return (sum);
        }      
        static int SumPathCost(Graph g, int vertex, bool[] visited, int sum, int startingVertex)
        {
            

            if (visited[vertex] != true)
            {
                visited[vertex] = true;
                Console.WriteLine(vertex);
               // sum += g.vertexWeight[vertex].FirstOrDefault();
            
            }

            List<int> neighbours = g.vertex[vertex];

            
            foreach (var v in neighbours)
            {
                if (startingVertex == v)
                {
                   
                    sum = 0;
                }
                   

                if (visited[v] != true)
                    SumPathCost(g, v, visited, sum, startingVertex);


            }

            return sum;
        }


        static void BFS(Graph g, int pvertex)
        {
            bool[] visited = new bool[g.vertex.Length];

            BFSNavigate(g, pvertex, visited);
        }


        static Queue<int> q = new Queue<int>();
        static void BFSNavigate(Graph g, int vertex, bool[] visited)
        {
            if(visited[vertex]!=true)
            {
                visited[vertex] = true;
                Console.WriteLine(vertex);
            }

            List<int> neighbour = g.vertex[vertex];


            foreach(var v in neighbour)
            {
                if (visited[v] != true)
                {
                    visited[v] = true;
                    Console.WriteLine(v);
                    q.Enqueue(v);

                }    

            }

            
            while(q.Count > 0)
            {
                int nextnode = q.Dequeue();

                BFSNavigate(g, nextnode, visited);
            }



        }

        static void Main(string[] args)
        {

            Graph g = new Graph(4);


            AddEdges(g,0,1);
            AddEdges(g,0,3);
            AddEdges(g,0,2);

            AddEdges(g,1,0);
            AddEdges(g,1,3);
            AddEdges(g,1,2);


            AddEdges(g,3,1);
            AddEdges(g,3,0);
            AddEdges(g,3,2);

            AddEdges(g,2,0);
            AddEdges(g,2,1);
            AddEdges(g,2,3);


            /* AddEdges(g, 1-1, 2-1);
             AddEdges(g, 1-1, 3-1);
             AddEdges(g, 1-1, 5-1);

             AddEdges(g, 2-1, 3-1);
             AddEdges(g, 2-1, 4-1);
             AddEdges(g, 2-1, 5-1);

             AddEdges(g, 3-1, 1-1);
             AddEdges(g, 3-1, 2-1);
             AddEdges(g, 3-1, 4-1);

             AddEdges(g, 4-1, 3-1);
             AddEdges(g, 4-1, 2-1);
             AddEdges(g, 4-1, 5-1);

             AddEdges(g, 5-1, 1-1);
             AddEdges(g, 5-1, 2-1);
             AddEdges(g, 5-1, 4-1);*/


            //BFS(g, 0);
            DFS(g, 0,0);

            //sumGraph(g, 0);
            Console.ReadLine();
        }

    }
}
