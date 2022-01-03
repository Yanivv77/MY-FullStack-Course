using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilesManager manager = new FilesManager();
            manager.LoadFormFile();
            manager.DisplayData();
            manager.CheckSchools();
            manager.Check5AvgBack();


            Console.ReadLine();

        }
    }
}
