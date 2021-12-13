using RoadSys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaodSys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Road a = new Road()
            {
                Name = "TelAviv",
                Num = 5,
                Length = 100
            };


            Road b = new Road()
            {
                Name = "TelAviv",
                Num = 7,
                Length = 200
            };

            Road c = new Road()
            {
                Name = "TelAviv",
                Num = 4,
                Length = 300
            };


            Hashtable Roads = new Hashtable();

            for (int i = 0; i < 5; i++)
            {
                Road newRoad = new Road();

                Console.WriteLine("Enter Road Name ");
                newRoad.Name = Console.ReadLine();

                Console.WriteLine("Enter Road Num ");
                string  num = Console.ReadLine();
                newRoad.Num = int.Parse(num);

                Console.WriteLine("Enter Road lenth ");
                string len = Console.ReadLine();
                newRoad.Length = int.Parse(len);

                Console.WriteLine("Enter Road lanes number ");
                string Netivim = Console.ReadLine();
                newRoad.Netivim = byte.Parse(Netivim);

                Console.WriteLine("Enter Road cost ture/false ");
                string CostMoney = Console.ReadLine();
                newRoad.CostMoney = bool.Parse(CostMoney);


                Roads.Add(newRoad.Num, newRoad);

            }






























        }
    }
}
