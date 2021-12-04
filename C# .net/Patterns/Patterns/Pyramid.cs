using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patterns
{

    internal class Pyramid
    {



        //   *   row 1, 2 spaces, 1 star
        //  ***  row 2, 1 space, 3 stars
        // ***** row 3, 0 spaces, 5 starts
        public static void Pyramidd(int height)
        {
            for (int i = 1; i <= height; i++) // Number of rows (height)
            {

                for (int j = 0; j < height - i; j++) // Number of spaces (height - i) 
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < (i * 2); k++) // "*" (i*2) times for each row
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // ***** row 3, 0 spaces, 5 starts
        //  ***  row 2, 1 space, 3 stars
        //   *   row 1, 2 spaces, 1 star
        public static void ReversePyramid(int height)
        {
            for (int i = height - 1; i >= 1; i--)  // Number of rows (height)
            {

                for (int j = 1; j <= height - i; j++) // Number of spaces (height - i) 
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++) // "*" (i*2) times for each row
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

       




       




    }


}







