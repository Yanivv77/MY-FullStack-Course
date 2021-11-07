using System;

namespace ConsoleApp1
{
    class main
    {
        static void Main(string[] args)
        {
            Person Avi = new Person("Avi", "Male");

            Console.WriteLine(Avi.ToString());
            Avi.Name = "Ben";


            
            Console.WriteLine(Avi.ToString());
            


        }
    }
}
