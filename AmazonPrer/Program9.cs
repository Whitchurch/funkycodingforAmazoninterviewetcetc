using System;
using System.Collections.Generic;

namespace coursera
{
    class Program9
    {


        static void Main(string[] args)
        {

            string s = "This is a sti string sti Whitchurch Whitchurch Whitchurch";
            string[] ssplit = s.Split(" ");

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string item in ssplit)
            {

                if (words.ContainsKey(item))
                {
                    words[item] += 1;
                }
                else
                {
                    words.Add(item, 1);
                }
            }

            int biggest = 0;
            string maxrepeatedstting = "";
            foreach (var ite in words)
            {
                if (biggest < ite.Value)
                {
                    biggest = ite.Value;
                    maxrepeatedstting = ite.Key;
                }
            }

            Console.WriteLine("The most repeated word is {0}, repeated {1}", maxrepeatedstting, biggest);
        }
    }
}
