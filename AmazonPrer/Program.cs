using System;
using AmazonPrer.DataStructures;

namespace AmazonPrer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scratch Pad to test my Data Sctuctures");

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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
    }
}
