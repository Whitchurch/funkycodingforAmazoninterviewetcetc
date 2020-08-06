using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program12
    {

        static int partition(int l,int h,int[] parray)
        {
            int pivot = parray[l];

            int i = l;
            int j = h;

            while(i < j)
            {
                while(parray[i]<=pivot)
                {
                    i++;
                }

                while(parray[j] > pivot)
                {
                    j--;
                }

                if(i < j)
                {
                    int temp = parray[i];
                    parray[i] = parray[j];
                    parray[j] = temp;
                }
            }

            int temp1 = parray[j];
            parray[j] = parray[l];
            parray[l] = temp1;

            return j;

        }


        static int[]  quicksort(int l, int h, int[] parray)
        {
            if(l < h)
            {
                int p = partition(l, h, parray);
                quicksort(l, p, parray);
                quicksort(p + 1, h, parray);
            }


            return parray;

        }

        const int MAX = 1073741824;

        static void Main(string[] args)
        {
            int[] parray = { 10, 16, 8, 12, 15, 6, 3, 9, 5 ,MAX};

            parray = quicksort(0, parray.Length - 1, parray);

            Console.ReadLine();
        }

    }
}
