using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the superReducedString function below.
    static string superReducedString(string s)
    {

        s = reduceString(s, s.Length - 2, s.Length - 1);
        if (s.Length <= 0)
        {
            return (s = "Empty String");
        }
        else
        {
            return s;
        }

    }

    static string reduceString(string s, int min, int max)
    {
        if (min < 0)
            return s;


        if (s.Substring(min, 1) == s.Substring(max, 1))
        {
            s = s.Remove(min, 2);
            s = reduceString(s, s.Length - 2, s.Length - 1);
            return s;
        }
        else
        {
            min = min - 1;
            max = max - 1;
            s = reduceString(s, min, max);
            return s;
        }


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
