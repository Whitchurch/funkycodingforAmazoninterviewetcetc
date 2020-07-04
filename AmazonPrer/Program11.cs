using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        class datapacket
        {
            public int weight { get; set; }
            public int value { get; set; }

            public datapacket nextlink;


        }

        static int knapsack(datapacket d1head, int capacity)
        {
            if (capacity == 0 | d1head == null)
                return 0;

            if(d1head.weight > capacity)
            {
                d1head = d1head.nextlink;
               return(knapsack(d1head, capacity));
            }
            else
            {
                int tmp2 = knapsack(d1head.nextlink, capacity);
                int tmp1 = d1head.value + (knapsack(d1head.nextlink, capacity - d1head.weight));
               return( Math.Max(tmp2, tmp1));
            }
        }

        static void Main(string[] args)
        {
            datapacket data = new datapacket();
            data.weight = 2;
            data.value = 1;

            datapacket d1 = new datapacket();
            d1.weight = 3;
            d1.value = 2;
            data.nextlink = null;

            datapacket d2 = new datapacket();
            d2.weight = 4;
            d2.value = 5;
            d2.nextlink = null;

            datapacket d3 = new datapacket();
            d3.weight = 5;
            d3.value = 6;
            d3.nextlink = null;

            data.nextlink = d1;
            d1.nextlink = d2;
            d2.nextlink = d3;
            datapacket head = data;

            while(head != null)
            {
                Console.WriteLine(head.weight);
                head = head.nextlink;

            }

            Console.WriteLine(knapsack(data, 8));
            Console.ReadLine();


        }
    }
}
