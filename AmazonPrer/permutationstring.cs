using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {


        static char[] swapChar(char[] word,int startpos, int switchpos, int arraylength)
        {

            char[] result = new char[arraylength];
            word.CopyTo(result,0);
            char temp;

            temp = result[startpos];
            result[startpos] = result[switchpos];
            result[switchpos] = temp;
            return result;

        }

        static void permuteWord(string word, string add, int i)
        {


            if (word == String.Empty)
            {
                Console.WriteLine(add);
                return;
            }

            while (i < word.Length)
                {



                    add += word.Substring(i, 1);
                    word = word.Remove(i, 1);
                    if (i > 0)
                        i--;

                    permuteWord(word, add, i);
                i++;
                   
                }

            
            

        }

        static void Main(string[] args)
        {

            string word = "abc";
            string add = string.Empty;
            string remaining = string.Empty;
            // Console.WriteLine(word.Substring(0, 1));

            for(int i = 0; i <= word.Length; i++)
            {
                permuteWord(word, add, i);
                
            }
           
           
           
            Console.ReadKey();

        }
    }
}
