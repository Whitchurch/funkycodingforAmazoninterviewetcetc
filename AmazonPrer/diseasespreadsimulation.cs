using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        const int tag = 9;

        class positon
        {

            public int[] loxX { get; set; }
            public int[] loxY { get; set; }

            public positon(int size)
            {
                this.loxX = new int[size];
                this.loxY = new int[size];
            }
        }

        static bool repeatoperation(int[,] mat)
        {
            bool repeat = false;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j] != 1)
                    {
                        repeat = true;
                        
                    }
                }
                
            }
            return repeat;
        }

        static void displayMatrix(int[,]mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #region "Legacy Code"
       /* static positon analyzeMatrix(int[,] mat)
        {
            int[] loxX = new int[mat.Length];
            int[] loxY = new int[mat.Length];

            positon p1 = new positon(mat.Length);



            int xloc = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    //Get co-ordinate of neighbours
                    int right = (j+1) % (mat.GetLength(0));
                    int down = (i+1) % (mat.GetLength(0));
                    int up;
                    int left;

                    if(((i - 1) % (mat.GetLength(0))  >= 0))
                    {
                         up = (i - 1) % (mat.GetLength(0));
                    }
                    else
                    {
                         up = ((mat.GetLength(0))) + (i - 1) % (mat.GetLength(0));
                    }

                    if (((j - 1) % (mat.GetLength(0)) >= 0))
                    {
                         left = (j - 1) % (mat.GetLength(0));
                    }
                    else
                    {
                         left = ((mat.GetLength(0))) + (j - 1) % (mat.GetLength(0));
                    }

                   
                    

                    // Get values in the co-ordinates
                    int rightneighbour = mat[i,right];
                    int upneighbour = mat[up, j];
                    int downneighbour = mat[down, j];
                    int leftneighbour = mat[i, left];


                    //Tag those elements who's neighours are 1, for replacement in the next flip.
                    if (rightneighbour == 1 | upneighbour == 1 | downneighbour == 1 | leftneighbour == 1)
                    {
                           
                            p1.loxX[xloc] = i;
                            p1.loxY[xloc] = j;

                            xloc++;


                     
                    }

                }
            
            }
            return p1;
        }

        static int[,] makechangestoMat(int[,]mat, positon p1)
        {
            for(int i = 0; i < p1.loxX.Length; i++)
            {
                mat[p1.loxX[i], p1.loxY[i]] = 1;
            }

            return mat;
        }*/
        #endregion

        static int[,] makechangestoMat1(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j] == tag)
                    {
                        mat[i, j] = 1;
                    }
                }
            }

            return mat;
        }

        static int[,] analyzeMatrix1(int[,] mat)
        {

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    //Get co-ordinate of neighbours
                    int right = (j + 1) % (mat.GetLength(0));
                    int down = (i + 1) % (mat.GetLength(0));
                    int up;
                    int left;

                    if (((i - 1) % (mat.GetLength(0)) >= 0))
                    {
                        up = (i - 1) % (mat.GetLength(0));
                    }
                    else
                    {
                        up = ((mat.GetLength(0))) + (i - 1) % (mat.GetLength(0));
                    }

                    if (((j - 1) % (mat.GetLength(0)) >= 0))
                    {
                        left = (j - 1) % (mat.GetLength(0));
                    }
                    else
                    {
                        left = ((mat.GetLength(0))) + (j - 1) % (mat.GetLength(0));
                    }




                    // Get values in the co-ordinates
                    int rightneighbour = mat[i, right];
                    int upneighbour = mat[up, j];
                    int downneighbour = mat[down, j];
                    int leftneighbour = mat[i, left];


                    //Tag those elements who's neighours are 1, for replacement in the next flip.
                    if (rightneighbour == 1 | upneighbour == 1 | downneighbour == 1 | leftneighbour == 1)
                    {

                        mat[i, j] = tag;

                    }

                }

            }
            return mat;
        }

        static void Main(string[] args)
        {

            int[,] mat = { { 0, 0,0,0,0,0 },{ 0,0,0,0,0,0},{ 0,0,0,1,0,0},{0,0,0,0,0,0 },{ 0,0,0,0,0,0},{ 0,0,0,0,0,0} };

            int turns = 0;

            //Display seed starting matrix
             displayMatrix(mat);
     
                while(repeatoperation(mat) == true)
            {
                
                mat = analyzeMatrix1(mat);
                mat = makechangestoMat1(mat);
                displayMatrix(mat);
                turns++;

            }


            Console.WriteLine("Number of turns to convert all 0s with adjacent 1 and entire matrix to ones:");
            Console.Write(turns);

            Console.ReadKey();

        }
    }
}

