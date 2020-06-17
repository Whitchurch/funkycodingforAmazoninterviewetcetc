using System;
namespace AmazonPrer.Recursion
{
    public class addArray
    {

        public int addArrayFunc(int[] a, int length)
        {
            if(length == 0)
            {
                return a[length];
            }
            else
            {
                return (a[length]+addArrayFunc(a, length - 1));
            }
                

        }
        public addArray()
        {
        }
    }
}
