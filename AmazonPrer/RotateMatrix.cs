using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        static Queue<int> queueStore = new Queue<int>();

        static void displayMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }
        }


        static int[,] createMatrix(int[,] mat, position p, int up, int down, int right, int left)
        {
            if (p.turns >= mat.Length)
                return mat;

            p = createmoveRight(mat, up, down, right, left, p);

            p = createmoveDown(mat, up, down, right, left, p);

            p = createmoveLeft(mat, up, down, right, left, p);

            p = createmoveUp(mat, up, down, right, left, p);


            p.posY++;
            p.posX++;

            left++;
            right--;
            up++;
            down--;



            createMatrix(mat, p, up, down, right, left);

            return mat;
        }


        class position
        {
            public int posX { get; set; }
            public int posY { get; set; }
            public int turns { get; set; }

        }


        static position createmoveRight(int[,] mat, int up, int down, int right, int left, position p)
        {
            while (p.posY < right)
            {
                //Console.Write(mat[p.posX, p.posY]);

                mat[p.posX,p.posY] = queueStore.Dequeue();
                p.turns++;
                p.posY++;
            }

            return p;
        }

        static position createmoveDown(int[,] mat, int up, int down, int right, int left, position p)
        {
            while (p.posX < down)
            {
                //Console.Write(mat[p.posX, p.posY]);
                mat[p.posX, p.posY] = queueStore.Dequeue();
                p.turns++;
                p.posX++;
            }
            return p;
        }

        static position createmoveLeft(int[,] mat, int up, int down, int right, int left, position p)
        {
            while (p.posY > left)
            {
                //Console.Write(mat[p.posX, p.posY]);
                mat[p.posX, p.posY] = queueStore.Dequeue();
                p.turns++;
                p.posY--;
            }

            return p;
        }

        static position createmoveUp(int[,] mat, int up, int down, int right, int left, position p)
        {
            while (p.posX > up)
            {
                //  Console.Write(mat[p.posX, p.posY]);
                mat[p.posX, p.posY] = queueStore.Dequeue();
                p.turns++;
                p.posX--;
            }

            return p;
        }

        static position moveRight(int[,] mat,int up, int down, int right, int left, position p)
        {
            while(p.posY < right)
            {
                //Console.Write(mat[p.posX, p.posY]);

                queueStore.Enqueue(mat[p.posX, p.posY]);
                p.turns++;
                p.posY++;
            }

            return p;
        }

        static position moveDown(int[,] mat, int up, int down, int right, int left, position p)
        {
            while(p.posX < down)
            {
                //Console.Write(mat[p.posX, p.posY]);
                queueStore.Enqueue(mat[p.posX, p.posY]);
                p.turns++;
                p.posX++;
            }
            return p;
        }

        static position moveLeft(int[,] mat, int up, int down, int right, int left, position p)
        {
            while(p.posY > left)
            {
                //Console.Write(mat[p.posX, p.posY]);
                queueStore.Enqueue(mat[p.posX, p.posY]);
                p.turns++;
                p.posY--;
            }

            return p;
        }

        static position moveUp(int[,] mat, int up, int down, int right, int left, position p)
        {
            while(p.posX > up)
            {
                //  Console.Write(mat[p.posX, p.posY]);
                queueStore.Enqueue(mat[p.posX, p.posY]);
                p.turns++;
                p.posX--;
            }

            return p;
        }


        static void spiralMatrix(int[,] mat, position p, int up, int down, int right, int left)
        {

            if (p.turns >= mat.Length)
                return;

            p = moveRight(mat, up, down, right, left, p);
            
            p = moveDown(mat, up, down, right, left, p);
            
            p = moveLeft(mat, up, down, right, left, p);
            
            p = moveUp(mat, up, down, right, left, p);
            

            p.posY++;
            p.posX++;

            left++;
            right--;
            up++;
            down--;

            

            spiralMatrix(mat, p, up, down, right, left);

        }

        static void Main(String[] args)
        {
            int[,] mat = { { 1, 2, 3, 4 }, {12,1,2,5 }, { 11,4,3,6 }, { 10,9,8,7}};
            displayMatrix(mat);

            int right = mat.GetLength(0) - 1;
            int left = mat.GetLowerBound(0);

            int down = mat.GetLength(1) - 1;
            int up = mat.GetLowerBound(1);

            position p = new position();
            p.posX = left;
            p.posY = up;
            p.turns = 0;

            

            spiralMatrix(mat, p, up, down, right, left);

            int rotate = 2;
            int tries = 0;

            while(tries < rotate)
            {
                var tempitem = queueStore.Dequeue();
                queueStore.Enqueue(tempitem);
                tries++;
            }


            p = new position();
            p.posX = left;
            p.posY = up;
            p.turns = 0;

            mat = createMatrix(mat, p, up, down, right, left);

            displayMatrix(mat);

            Console.ReadLine();
        }

    }
}
