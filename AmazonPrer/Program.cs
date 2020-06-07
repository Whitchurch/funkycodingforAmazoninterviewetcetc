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

                Console.WriteLine(n1.getNodeValue());
                Console.WriteLine(n1.getNextNodePointerValue());

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
    }
}
