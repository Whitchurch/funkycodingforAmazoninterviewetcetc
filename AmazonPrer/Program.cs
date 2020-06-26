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

            Node tracker;

            int caseswitch = 9;
            switch(caseswitch)
            {

                case 9:
                    try
                    {
                        string input = "SOSSPSSQSSOR";
                        marsExploration(input);

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    break;
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

                        tracker = result;

                        int newnumber = 77;
                        list.insertNodeAtHead(tracker, newnumber);

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 5:
                    try
                    {

                        singleInteger s1 = new singleInteger();
                        int result = s1.retSingleIngeter(456777);
                        Console.WriteLine("Single digit result");
                        Console.WriteLine(result);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 6:
                    try
                    {

                        reverseInteger s1 = new reverseInteger();
                        s1.reverseIntegerfunc(123);
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 7:
                    try
                    {

                        addArray a1 = new addArray();
                        int[] item = { 1, 2, 3, 4, 5 };
                        Console.WriteLine(a1.addArrayFunc(item, (item.Length)-1));
                       
                        

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case 8:
                    try
                    {
                        int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                        int nrows = 4;
                        int ncols = 4;

                        for(int i = 0; i<ncols-1; i++)
                        {
                            Console.WriteLine(a[0,i]);
                        }

                        for(int i = 0; i<nrows-1;i++)
                        {
                            Console.WriteLine(a[i, ncols - 1]);
                        }

                        for (int i = ncols-1; i > 0; i--)
                        {
                            Console.WriteLine(a[ncols-1,i]);
                        }

                        for (int i = nrows-1; i> 0; i--)
                        {
                            Console.WriteLine(a[i,0]);
                        }

                        int[,] a1 = {{ 6, 7}, { 10, 11 } };
                        nrows = 2;
                        ncols = 2;

                        for (int i = 0; i < ncols - 1; i++)
                        {
                            Console.WriteLine(a1[0, i]);
                        }

                        for (int i = 0; i < nrows - 1; i++)
                        {
                            Console.WriteLine(a1[i, ncols - 1]);
                        }

                        for (int i = ncols - 1; i > 0; i--)
                        {
                            Console.WriteLine(a1[ncols - 1, i]);
                        }

                        for (int i = nrows - 1; i > 0; i--)
                        {
                            Console.WriteLine(a1[i, 0]);
                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                    }

            

            }

        static int marsExploration(string s)
        {

            return CountSOS(s, s.Length, s.Length / 3, 0);
        }

        static int CountSOS(string s, int lengthString, int turns, int count)
        {

            while (turns < lengthString)
            {
                CountSOS(s.Substring(turns, 3), lengthString, turns, count);
                count += 1;
                turns += 3;
            }

            return count;

        }


    }
    }

