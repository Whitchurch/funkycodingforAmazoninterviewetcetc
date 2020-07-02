using System;

namespace coursera
{
    class Program6
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int start = s;
            int end = t;

            int aCOG = a;
            int bCOG = b;

            int pos = 0;
            int count = 0;
            InsideRange(apples, aCOG, pos, start, end, count);
            InsideRange(oranges, bCOG, pos, start, end, count);

        }

        static void InsideRange(int[] fruit, int COG, int pos, int start, int end, int count)
        {
            if (pos > (fruit.Length) - 1)
            {
                Console.WriteLine(count);
                return;
            }


            int positionValue = fruit[pos] + COG;

            if (positionValue >= start && positionValue <= end)
            {
                count++;
                pos++;
            }
            else
            {
                pos++;
            }
            InsideRange(fruit, COG, pos, start, end, count);

        }


        static void Main(string[] args)
        {
            int[] apples = { -2, 2, 1 };
            int[] oranges = { 5, -6 };

            countApplesAndOranges(7, 11, 5, 15, apples, oranges);

        }
    }
}
