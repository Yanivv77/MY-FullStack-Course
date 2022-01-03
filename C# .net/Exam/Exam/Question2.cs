using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question2
    {

        public static void Cal(int num1, int num2)
        {

            double counter = 0;
            int i = num1 - num2;

        while (i >= 0)
			{
                
                counter++;
                i -= num2;
            }
            

           Console.Write(counter);
           

        }




        public static void MultiplicationBoard(int size)
        {
           
            string str = "";

            for (int i = 1; i < size+1; i++)
            {
                for (int j = 1; j < size+1; j++)
                {
                    str += " ";
                    String multi = (i * j).ToString();
                    str += multi;

                    if (multi.Length == 1)
                    {
                        str += " ";
                    }


                }
                str += "\n";
            }

            Console.WriteLine(str);
        }





        public static void MultiplicationBoard(int row , int col)
        {

            string str = "";

            for (int i = 1; i < row + 1; i++)
            {
                for (int j = 1; j < col + 1; j++)
                {
                    str += " ";
                    String multi = (i * j).ToString();
                    str += multi;

                    if (multi.Length == 1)
                    {
                        str += " ";
                    }


                }
                str += "\n";
            }

            Console.WriteLine(str);
        }

        e











    }
}
