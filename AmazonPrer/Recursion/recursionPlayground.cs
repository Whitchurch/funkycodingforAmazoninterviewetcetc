using System;
namespace AmazonPrer.Recursion
{
    public class recursionPlayground
    {
        
        public recursionPlayground()
        {

        }

        public static int recurseAddMethod(int[] dataparam, int start)
        {
            if (start == dataparam.Length)
                return 0;

            start++;
            return recurseAddMethod(dataparam, start) + start;    

        }

        public static void recurseTree(int[] dataparam,int start)
        {
            if (start > dataparam.Length)
                return;

            start++;
            recurseTree(dataparam, start = 2 * start);
            Console.WriteLine(start);
        }
    }
}
