using Mysql.examples;
using System;

namespace Console_Mysql_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            try
            {
                MysqlExamples.MySqlRunStoredProcuder("ronaldo","fifa");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Done");
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
