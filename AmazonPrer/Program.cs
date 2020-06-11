using System;
using AmazonPrer.DataStructures;
using AmazonPrer.Recursion;

namespace AmazonPrer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scratch Pad to test my Data Sctuctures");

            int caseswitch = 4;
            switch(caseswitch)
            {
                case 1:
                    #region "LinkedList"
                    try
                    {
                        Node n1 = new Node();
                        n1.setNodeValue(23);
                        n1.setNextNodePointerValue(null);

                        Node n2 = new Node();
                        n2.setNodeValue("Hello");
                        n2.setNextNodePointerValue(null);

                        Node n3 = new Node();
                        n3.setNodeValue(23.45);
                        n3.setNextNodePointerValue(null);

                        list l1 = new list();
                        l1.AddItem(n1);

                        l1.AddItem(n2);
                        l1.AddItem(n3);

                        l1.printAll();


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    #endregion
                    break;

                case 2:
                    try
                    {
                        //Create a tree, specifying each of the node values manually
                       // treeNode T1 = new treeNode();
                       // T1.createTreeNode(23);
                       // T1.rightchild = new treeNode().createTreeNode(45);
                       // T1.leftchild = new treeNode().createTreeNode(100);
                       // Console.WriteLine(T1);

                        //Create a tree from an array of values (no order, generate children by appearance in the array)

                        int[] data = { 7,5,10,3,6,9,12 };
                        treeNode T2 = new treeNode().GenerateTreeFromArray(data);

                        Console.WriteLine("Inorder traversal");
                        T2.inorder(T2);

                        Console.WriteLine("Preorder Traversal");
                        T2.preorder(T2);

                        Console.WriteLine("Postorder Traversal");
                        T2.postorder(T2);


                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 3:
                    try
                    {
                     
                        int[] a = { 1, 2, 3, 4, 5 };
                        int Total = 0;
                        Total += recursionPlayground.recurseAddMethod(a, 0);
                        Console.WriteLine(Total);
                        recursionPlayground.recurseTree(a, 0);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 4:
                    try
                    {
                        int[] data = { 7, 5, 10, 3, 6, 9, 12 };
                        list T3 = new list();
                        Node result = T3.arrayTolist(data); 

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;


            }


        }
    }
}
