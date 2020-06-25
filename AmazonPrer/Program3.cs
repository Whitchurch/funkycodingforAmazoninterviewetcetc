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

    // Complete the camelcase function below.
    static int camelcase(string s)
    {
        int result = 0;
        result = countWords(s, 0, s.Length);
        return (result);
    }

    static int countWords(string s, int index, int stringLength)
    {
        int count = 1;
        while (index < stringLength)
        {
            if (s.Substring(index, 1).Any(char.IsUpper))
            {
                count += 1;
            }
            index++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
