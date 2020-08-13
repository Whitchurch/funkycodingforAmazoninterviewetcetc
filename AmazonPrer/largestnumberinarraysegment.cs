using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        static int biggestnumber(int[] pdataarray, int l, int h, int result)
        {
            if(l < h)
            {
                int mid = (l + h) / 2;

                int leftside = biggestnumber(pdataarray, l, mid,result);
                int rightside = biggestnumber(pdataarray, mid + 1, h,result);

                if(leftside > rightside)
                {
                    result = leftside;
                }
                else
                {
                    result = rightside;
                }
            }
            else
            {
                result = pdataarray[l];
            }

            return result;

        }

        static void Main(String[] args)
        {
            int[] dataarray = { 1, 10, 3, 7, 12,66,77,10000,1010,100,300,450000,2,7,8,12,15 };

            int result = biggestnumber(dataarray, 0, dataarray.Length - 1, 0);

            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
