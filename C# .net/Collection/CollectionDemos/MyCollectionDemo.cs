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
            var order = people.OrderBy(x => x.first_name); // Sort array of people x by first_name
          
           
            

//             foreach (var p in order)
//             {
//                 
//                 Console.WriteLine(p);
//             }



            //Dictionary

            Dictionary<int, Person> pepoleMap = people.ToDictionary(x => x.id);

                foreach (KeyValuePair<int, Person> person in pepoleMap)
                {
                    Console.WriteLine("Key: {0}, Value:{1}", person.Key , person.Value);
                }
            






        }

       
    }
}
