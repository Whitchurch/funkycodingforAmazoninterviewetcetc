using System;
namespace AmazonPrer.Recursion
{
    public class reverseInteger
    {
        public void reverseIntegerfunc(int num)
        {

                if(num/10 != 0)
                {
                    Console.WriteLine(num % 10);
                    num = num / 10;
                    reverseIntegerfunc(num);
                }
                else
            {
                Console.WriteLine(num);
            }
                
    
        }

        public reverseInteger()
        {
        }
    }
}
