using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        public  static char reverse(char[] input,int index,char[]output)
        {
            if (index <= 0)
            {
                output[(output.Length-index)-1] = input[index];
                return output[index];
            }



            output[(output.Length - index)-1] = input[index];
            index--;
           return(reverse(input, index,output));
            
           
        }

        static void Main(string[] args)
        {
            char[] input = { 'H', 'e', 'y', ' ', 'm', 'a', 'n' };
            char[] output = new char[input.Length];
            reverse(input,input.Length-1,output);

            Console.WriteLine(output);
            Console.ReadLine();

        }

    }
}
