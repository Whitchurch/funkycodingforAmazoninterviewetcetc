using System;

namespace coursera
{
    class Program7
    {
        class position
        {
            public int x { get; set; }
            public int y { get; set; }
            public int result { get; set; }
        }

        static void printMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.Length / 3; i++)
            {
                for (int j = 0; j < mat.Length / 3; j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int Traverse(position p1, int level, int[,] mat, int sum)
        {

            if (level == 0)
            {
                //Console.WriteLine(p1.result);
                return sum += p1.result;
            }
            else
            {
                level--;
            }

            sum += p1.result;

            //Console.WriteLine(p1.result);

            p1.result = mat[p1.x, p1.y + 1];
            p1.x = p1.x;
            p1.y = p1.y + 1;
            int sum1 = Traverse(p1, level, mat, sum);
            p1.y = (3 + (p1.y - 1)) % (mat.Length / 3);
            //  p1.result = mat[p1.x, p1.y - 1];


            p1.result = mat[(p1.x + 1) % (mat.Length / 3), (p1.y + 1)];
            p1.x = (p1.x + 1) % (mat.Length / 3);
            p1.y = (p1.y + 1);
            int sum2 = Traverse(p1, level, mat, sum);
            p1.x = (3 + (p1.x - 1)) % (mat.Length / 3);
            p1.y = (3 + (p1.y - 1)) % (mat.Length / 3);
            // p1.result = mat[(3+(p1.x - 1)) % (mat.Length / 3), p1.y - 1];



            p1.result = mat[(3 + (p1.x - 1)) % (mat.Length / 3), p1.y + 1];
            p1.x = (3 + (p1.x - 1)) % (mat.Length / 3);
            p1.y = p1.y + 1;
            int sum3 = Traverse(p1, level, mat, sum);
            p1.x = (p1.x + 1) % (mat.Length / 3);
            p1.y = (3 + (p1.y - 1)) % (mat.Length / 3);

            int smallest = 0;

            if (smallest < sum1)
            {
                smallest = sum1;
            }

            if (sum2 < smallest)
            {
                smallest = sum2;
            }

            if (sum3 < smallest)
            {
                smallest = sum3;
            }

            return (smallest);


        }

        static void Main(string[] args)
        {

            int[,] mat = { { 3, 2, 3 }, { 1, 9, 1 }, { 2, 1, 2 } };
            position p1 = new position();
            p1.result = mat[1, 0];
            p1.x = 1;
            p1.y = 0;
            Console.WriteLine(Traverse(p1, (mat.Length / 3) - 1, mat, 0));
            //printMatrix(mat);
            //Console.WriteLine(shortestPath(mat,0,0,mat.Length-2,0,0));

        }
    }
}
