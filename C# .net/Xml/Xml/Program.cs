using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"https://www.globes.co.il/webservice/rss/rssfeeder.asmx/FeederNode?iID=1225");

            var allAuthor = doc.ChildNodes[1].SelectNodes(@"//item//author");

            foreach (XmlNode node in allAuthor)
            {
                XmlNode n = node;
                string author =n.InnerText;
                Console.WriteLine(author);

            }

            Console.ReadLine();
        }
    }
}
