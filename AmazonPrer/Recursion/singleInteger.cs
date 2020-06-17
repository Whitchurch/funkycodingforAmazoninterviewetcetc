using System;
namespace AmazonPrer.Recursion
{
    public class singleInteger
    {
        public int number { get; set; }

        public int retSingleIngeter(int number)
        {
            if(number/10 == 0)
            {
                return number;
            }
            else
            {
                return(retSingleIngeter(number / 10 + number % 10));
            }

           
        }
        public singleInteger()
        {
            

        }
    }
}
