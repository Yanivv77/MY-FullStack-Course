using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Square
    {


        // l = 3 , w = 4
        //**** row 1 , stars 4
        //**** row 2 , stars 4
        //**** row 3 , stars 4



        public static void SolidSquare(int length, int width)
        {
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < width; j++)
                {

                    Console.Write("*");

                }

                Console.WriteLine();

            }

        }
        // l = 4 , w = 5
        //***** row 1 , stars 4 , speaces 0
        //*   * row 2 , stars 2 , speaces 3
        //*   * row 3 , stars 2 , speaces 3
        //***** row 4 , stars 4  ,speaces 0

        public static void HollowSquare(int length, int width)
        {

            for (int i = 1; i <= length; i++)
            {

                if (i == 1 || i == length)
                {

                    for (int k = 1; k <= width; k++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {

                    for (int j = 1; j <= width; j++)
                    {
                        if (j == 1 || j == width)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                }

                Console.WriteLine();



            }


        }

    }


}




    

