using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {

        static int[] SortStuff(int[] c)
        {
            for(int i = 0;  i<=c.Length-1; i++)
            {
                for(int j = i+1; j <= c.Length-1; j++)
                {
                    int temp = 0;
                    if(c[i] > c[j])
                    {
                        temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
               
            }
            return c;
        }

        static int[] applyRank(int[]rank, int limit, int turns,int startrank,int constantturns)
        {
            
            int turnstemp = turns;

            if (limit < 0)
                return rank;

            if (turnstemp >= 0)
            {
                rank[limit] = startrank;
                limit = limit - 1;
                turnstemp = turnstemp - 1;
                return(applyRank(rank, limit, turnstemp, startrank,constantturns));
            }
            else
            {
                turnstemp = constantturns;
                startrank = startrank + 1;
                return(applyRank(rank, limit, turnstemp, startrank,constantturns));
            }

        }

        static void Main(string[] args)
        {

            int flowers = 50;
            int people = 3;

            int[] cost = { 390225, 426456, 688267, 800389, 990107, 439248, 240638, 15991, 874479, 568754, 729927, 980985, 132244, 488186, 5037, 721765, 251885, 28458, 23710, 281490, 30935, 897665, 768945, 337228, 533277, 959855, 927447, 941485, 24242, 684459, 312855, 716170, 512600, 608266, 779912, 950103, 211756, 665028, 642996, 262173, 789020, 932421, 390745, 433434, 350262, 463568, 668809, 305781, 815771, 550800 };
            int[] rank = new int[cost.Length];

            //Sort the flower costs. From highest to the lowest.
            int[] sort = SortStuff(cost);

            //Assign ranks to the flower costs based on people available.
            rank = applyRank(rank, flowers-1, people-1,1,people-1);

            //Calculate the greedy total.
            int GreedyTotal = 0;
            for(int i = 0; i<=rank.Length-1; i++)
            {
                GreedyTotal += cost[i] * rank[i];
            }

            Console.WriteLine(GreedyTotal);

        }
    }
}
