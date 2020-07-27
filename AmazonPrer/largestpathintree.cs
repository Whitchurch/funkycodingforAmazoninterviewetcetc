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
           public int data;
           public  node lnode;
           public node rnode;

            public node()
            {

            }

            public node(int d)
            {
                this.data = d;
                this.lnode = null;
                this.rnode = null;
            }

            public node(int d, node plnode, node prnode)
            {
                this.data = d;
                this.lnode = plnode;
                this.rnode = prnode;
            }

            
        }

        class treestruct
        {
            public node head;
            
            public treestruct()
            {
                head = null;
            }
        }


        static treestruct createTree(treestruct t, int[] treearray, node track)
        {

            int i = 0;
            Queue<int> tnodes = new Queue<int>();
            tnodes.Enqueue(treearray[i]);
            node tracker = track;
            
            while(tnodes.Count > 0)
            {
                int value = tnodes.Dequeue();
                node temp = new node(value);

                if (tracker == null)
                {
                    tracker = temp;
                }
                else if(tracker.lnode == null)
                {
                    tracker.lnode = temp;
                }
                else if(tracker.rnode == null)
                {
                    tracker.rnode = temp;

                }

                    

                if(i < treearray.Length -1)
                {
                    i++;
                    tnodes.Enqueue(treearray[i]);
                    i++;
                    tnodes.Enqueue(treearray[i]);
                }



            }

            return t;
        }



        static void BFS(treestruct t)
        {

            
            Queue<node> node = new Queue<node>();
            node.Enqueue(t.head);

            while(node.Count >0)
            {
                node item = node.Dequeue();
                Console.WriteLine(item.data);

                if (item.lnode != null)
                    node.Enqueue(item.lnode);

                if (item.rnode != null)
                    node.Enqueue(item.rnode);
            }
            
        }

        public static int lsum = 0;
        public static int rsum = 0;
        public static bool unvisited = false;

        static int largestPath(treestruct t, node track,int sum)
        {
            if (track.lnode == null||track.rnode == null)
                return track.data;

            if(unvisited != true)
            sum += track.data;

            sum += Math.Max(largestPath(t, track.lnode, sum), largestPath(t, track.rnode, sum));
            if (lsum == 0)
            {
                lsum = sum;
            }
            else
            {
                rsum = sum;
                unvisited = true;
            }
                
            return (sum);
        }

        static void Main(string[] args)
        {
            int[] treedata = { 25, 15, 7, 10, 12, 6, 5 };
            int[] treedata1 = { 1, 2, 3, 4, 5, 6, 7 };
            treestruct t = new treestruct();

            //t.head = new node(25, new node(15,new node(10),new node(12)), new node(7, new node(6),new node(5)));
            t.head = new node(1, new node(2, new node(4), new node(5)), new node(3, new node(6), new node(7)));
            //BFS(t);

            largestPath(t, t.head,0);
            Console.WriteLine(Math.Max(lsum, rsum-t.head.data));
            Console.ReadLine();
            
        }
    }
}
