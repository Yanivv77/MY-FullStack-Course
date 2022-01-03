using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHaim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataManager manager = new DataManager();
            manager.LoadFormFile();
            //manager.DisplayData();
            manager.QueryData();

            Console.ReadLine();

        }
    }
}
