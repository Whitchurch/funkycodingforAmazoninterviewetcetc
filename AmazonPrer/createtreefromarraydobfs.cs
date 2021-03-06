using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        class points
        {
            public int data { get; set; }
            public points rside { get; set; }
            public points lside { get; set; }

            public points()
            {
                this.rside = null;
                this.lside = null;
            }

            public points(int pdata)
            {
                this.data = pdata;
                this.rside = null;
                this.lside = null;
            }
        }


        class treeresult
        {
            public points head { get; set; }

            public treeresult()
            {
                this.head = null;
            }

            public treeresult(points phead)
            {
                this.head = phead;
            }
        }


        static points createTreeFromArray(int[] pdataarray, points root, int pos)
        {
            //Terminate recursion is all elements of array have been visited
            if (pos >= pdataarray.Length)
                return null; ;

            //Create the tree node from array element.
            root = new points(pdataarray[pos]);

            //Go down recursively adding in all left child elements
            root.lside = createTreeFromArray(pdataarray, root.lside, 2 * pos + 1);

            //Go down recursively adding in all the right child elements
            root.rside = createTreeFromArray(pdataarray, root.rside, 2 * pos + 2);

            return root;
        }

        static void BFS(treeresult pt)
        {
            Queue<points> q = new Queue<points>();
            q.Enqueue(pt.head);

            while(q.Count > 0)
            {
                points node = new points();
                node = q.Dequeue();
                Console.Write(node.data);

                if (node.lside != null)
                    q.Enqueue(node.lside);

                if (node.rside != null)
                    q.Enqueue(node.rside);
            }
        }

        static void Main(string[] args)
        {


            int[] dataarray = { 1, 2, 3, 4, 5, 6, 7 };
      
            treeresult t = new treeresult();

            t.head = createTreeFromArray(dataarray, t.head, 0);

            BFS(t);
            
            Console.ReadLine();

        }

    }
}
