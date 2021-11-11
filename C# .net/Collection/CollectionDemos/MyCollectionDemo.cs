using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LinqDemo.Models;
using Newtonsoft.Json;


namespace CollectionDemos
{
    public class MyCollectionDemo
    {
        public static void Run()
        {
            Console.WriteLine("myCollectionDemo");

            var exePath = Path.GetDirectoryName(typeof(MyCollectionDemo).Assembly.Location); //Path of the data file
            var filename = Path.Combine(exePath, "Data", "MOCK_DATA.json"); // Load file
            var text = File.ReadAllText(filename); // Read text
            var people = JsonConvert.DeserializeObject<List<Person>>(text); // Convert text to object
            var orderby = people.OrderBy(x => x.first_name);
            var str = String.Concat(orderby.Select(o => o.ToString()));

            Dictionary<int, Person> pepoleMap = people.ToDictionary(x => x.id);
            var vip = pepoleMap[20];







            foreach (var p in orderby)
            {
                
                Console.WriteLine(p);
            }
          

        }

       
    }
}
