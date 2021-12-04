using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Triangle
    {

        // n=3
        // *   row 1, 1 star
        // **  row 2, 2 stars
        // *** row 3, 3 starts

        public static void TriangleUp(int n)
        {


            for (int i = 1; i <= n; i++) // Number of rows
            {

                for (int j = 1; j <= i; j++) // Number of starts
                {

                    Console.Write("*"); 

                }
                Console.WriteLine();


            }
        }

        // n=3
        // *** row 1, 3 star
        // **  row 2, 2 stars
        // *   row 3, 1 starts

        public static void TriangleDown(int n)
        {


            for (int i = n; i >= 1; i--) // Number of rows
            {

                for (int j = 1; j <= i; j++)// Number of starts
                {

                    Console.Write("*"); 

                }
                Console.WriteLine();


            }
        }

        // n=3
        // i=1   *   row 1, 2 spaces, 1 star
        // i=2  **   row 2, 1 space, 2 stars
        // i=3 ***   row 3, 0 spaces, 3 starts
        public static void TriangleUpReverse(int n)
        {


            for (int i = 1; i <= n; i++)  // Number of rows
            {

                for (int j = 0; j < n - i; j++) // Number of spaces (n - i) 
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < (i); k++) // // Number of starts (i)

                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        // n=3
        // i=1 ***   row 3, 0 spaces, 3 starts
        // i=2  **   row 2, 1 space, 2 stars
        // i=3   *   row 1, 2 spaces, 1 star
        public static void TriangleDownReverse(int n)
        {


            for (int i = n - 1; i >= 1; i--)  // Number of rows n
            {

                for (int j = 1; j <= n - i; j++) // Number of spaces (n-i) 
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i ; k++) // // Number of starts (i)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }




    }




}    
