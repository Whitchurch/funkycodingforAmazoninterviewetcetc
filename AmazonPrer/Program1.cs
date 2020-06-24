using System;
using System.Collections.Generic;
using System.Linq;
namespace hackerranker
{
    class Program
    {

        public class result
        {
            public int first = 0;
            public int second = 0;
        }

        public class pos
        {
            public int x { get; set; }
            public int y { get; set; }
        }


        static void Main(string[] args)
        {

            int[] a = { 1, 1, 1, 1, 1, 1 };
            int[] b = { 0, 0, 0, 0, 0, 0 };


            int[] inputmagicsquare = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GenMagicSquare(7);



        }


        //Generate Magic square
        static void GenMagicSquare(int size)
        {

            //Create empty placeholder matrix for magic square
            int[,] MS = new int[size, size];


            //Calculate position of 1.
            pos resultpos = CalculatePosition(size);

            int i = 1;

            //Insert element in Magic Square
            insertElement(resultpos, MS, i, size);

            //Display the Magic Square Matrix:
            for (int irow = 0; irow < size; irow++)
            {
                for (int icol = 0; icol < size; icol++)
                {
                    Console.Write(MS[irow, icol]);
                }
                Console.WriteLine();
            }


        }

        static void insertElement(pos p, int[,] MS, int element, int size)
        {
            while (element <= (size * size))
            {
                if (MS[p.x, p.y] == 0)
                {
                    //Insert element;
                    MS[p.x, p.y] = element;

                    //Decrement row by 1, increment columns by 1
                    p.x = (p.x - 1) % size;
                    if (p.x < 0)
                        p.x = size + p.x;

                    p.y = (p.y + 1) % size;
                    //Go to nextxt element
                    element += 1;

                }
                else if (MS[p.x, p.y] != 0)
                {
                    //decrease 2 columns, increase 1 row.
                    p.y = (p.y - 1) % size;
                    if (p.y < 0)
                        p.y = size + p.y;

                    p.y = (p.y - 1) % size;
                    if (p.y < 0)
                        p.y = size + p.y;

                    p.x = (p.x + 1) % size;
                }
            }

        }



        static pos CalculatePosition(int size)
        {
            pos p = new pos();
            p.x = size / 2;
            p.y = size - 1;
            return p;
        }


        //Swap itms between conatiners

        static void readItem(int[] arr1, int[] arr2, int length)
        {

            for (int i = 0; i < length; i++)
            {
                result rr = swapItems(arr1[i], arr2[i]);
                arr1[i] = rr.first;
                arr2[i] = rr.second;
            }

        }

        static result swapItems(int arr1, int arr2)
        {
            result r1 = new result();
            r1.first = arr2;
            r1.second = arr1;
            return r1;
        }



    }
}
