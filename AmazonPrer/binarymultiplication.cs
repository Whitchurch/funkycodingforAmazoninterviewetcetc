using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program22
    {

        static string ConvertDectoBinary(int pnumber,String preminder)
        {
            if (pnumber <= 1)
                return preminder = preminder.Insert(0,(pnumber % 2).ToString());

            preminder = preminder.Insert(0,(pnumber % 2).ToString());
            pnumber = pnumber / 2;

            return(ConvertDectoBinary(pnumber, preminder));

                
        }


        static String[] mulnooperator(int bin1, int bin2, int turns)
        {


            string binary1 = bin1.ToString();
            string binary2 = bin2.ToString();

            Console.WriteLine(binary1.Length);
            Console.WriteLine(binary2.Length);

            string last = binary2.Substring(binary2.Length - 1);
            string[] Result = new String[32];
            String tempbinary2 = String.Empty;
            
            
            while(turns <= binary2.Length)
            {
                if (last == "0")
                {

                    String temp = String.Empty;
                    int i = 0;
                    while(i < binary1.Length+turns)
                    {
                        temp += "0";
                        i++;
                    }

                    Result[turns] = temp;
                   


                }
                else if (last == "1")
                {


                    String temp = String.Empty;
                    temp = binary1;

                    int i = 0;
                    while (i < turns)
                    {
                        temp += "0";
                        i++;
                    }

                    Result[turns] = temp;
                    
                }

                turns++;



               if(tempbinary2.Equals(String.Empty))
                {
                    tempbinary2 = binary2.Remove(binary2.Length - 1);
                }
               else
                {
                    tempbinary2 = tempbinary2.Remove(tempbinary2.Length - 1);
                }

                if (tempbinary2.Equals(String.Empty))
                    return Result;

                last = tempbinary2.Substring(tempbinary2.Length - 1);
               
 
                    
                
               
            }

            return Result;
            ///binary2 = binary2.Remove(binary2.Length - 1);

            // mulnooperator(Convert.ToInt32(binary1), Convert.ToInt32(binary2), turns);

        }

        static void MainEx(String[] args)
        {
            int a = 3;
            int b = 2;

            String reminder = String.Empty;

            reminder = ConvertDectoBinary(a, reminder);
            int binarynumber_1 = Convert.ToInt32(reminder);

            reminder = String.Empty;

            reminder = ConvertDectoBinary(b, reminder);
            int binarynumber_2 = Convert.ToInt32(reminder);


            Console.WriteLine(binarynumber_1);
            Console.WriteLine(binarynumber_2);

           String[] r1  = mulnooperator(binarynumber_1, binarynumber_2,0);

            int i = 0;

            int container = 0;
            while(i < r1.Length)
            {
                container = container + Convert.ToInt32(r1[i]);
                i++;
            }


            Console.ReadLine();

        }

    }
}
