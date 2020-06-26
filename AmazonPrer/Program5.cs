using System;

namespace coursera
{
    class Program5
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int x1temp = x1;
            int x2temp = x2;
            if (x1 != x2)
            {

                x1temp += v1;
                x2temp += v2;

                if (v1 == v2)
                {
                    return ("NO");
                }

                if (Math.Abs(x1 - x2) > Math.Abs(x1temp - x2temp))
                {
                    return (kangaroo(x1temp, v1, x2temp, v2));
                }


                if (Math.Abs(x1 - x2) < Math.Abs(x1temp - x2temp))
                {
                    return ("NO");
                }

                return ("Unreachable test case");

            }
            else
            {
                return ("YES");
            }


        }


        static void Main(string[] args)
        {


            Console.WriteLine(kangaroo(43 2 70 2));

        }
    }
}
