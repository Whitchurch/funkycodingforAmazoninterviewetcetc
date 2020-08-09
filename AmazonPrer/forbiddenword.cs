using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace sandbox
{
    class Program
    {

        static string preprocess(String pstring)
        {

            pstring = pstring.ToLower();
            pstring = Regex.Replace(pstring, @"[^\w\s]", "");
            return pstring;
        }


        static Dictionary<String,int> createWordDictionary(String pstring, Dictionary<String, int> pdictionary)
        {

            String[] splitwords = pstring.Split(' ');

            foreach(var item in splitwords)
            {
               if(!pdictionary.ContainsKey(item))
                {
                    pdictionary.Add(item, 1);
                }
               else
                {
                    int i = pdictionary[item];
                    i++;

                    pdictionary[item] = i;
                }

            }

            return pdictionary;
        }


        

        static void Main(string[] args)
        {

            Dictionary<String, int> WordFrequency = new Dictionary<string, int>();
            String paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";

            Dictionary<String, bool> forbiddenwords = new Dictionary<string, bool>();
            forbiddenwords.Add("hit", true);

            String par1 = preprocess(paragraph);
            WordFrequency = createWordDictionary(par1, WordFrequency);

            var result =  WordFrequency.OrderBy(key => key.Value).Reverse();

            foreach(var item in result)
            {
                if(forbiddenwords.ContainsKey(item.Key))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item.Key);
                    break;
                }

            }

            Console.ReadLine();
            
        }

    }
}
