using System;

namespace coursera
{
    class Program
    {
        static int marsExploration(string s)
        {

            return (countWord(s, s.Length, 0, 0));
        }

        static int countWord(string s, int wordlength, int index, int count)
        {
            if (index >= wordlength)
                return count;

            string subword = s.Substring(index, 3);
            char[] a = subword.ToCharArray();
            if (a[0] != 'S')
            {
                count += 1;
            }
            if (a[1] != 'O')
            {
                count += 1;
            }
            if (a[2] != 'S')
            {
                count += 1;
            }
            index += 3;
            return (countWord(s, wordlength, index, count));
        }


        static void Main(string[] args)
        {
            string s = "WHIWHIWHI";

            Console.WriteLine(marsExploration(s));

        }
    }
}
