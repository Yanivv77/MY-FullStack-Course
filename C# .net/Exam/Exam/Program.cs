using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question2.MultiplicationBoard(10);
            //Question2.MultiplicationBoard(10,5);

            Question3.primeFactors(30);// = 2 3 5
            Question3.primeFactors(100);// = 2 2 5 5
            Question3.primeFactors(1024);// = 2 2 2 2 2 2 2 2 2 2
            Question3.primeFactors(726);// = 2 3 11 11
            

            Console.ReadLine();

        }
    }
}
