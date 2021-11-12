using ShopProject.Classes;
using ShopProject.Classes.Products.Books;
using ShopProject.Classes.Products.Digital;
using ShopProject.Classes.Products.Electronics;
using ShopProject.Enums;
using System;
using System.Collections;

namespace ShopProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try
            {
                //Authors 

                Author author1 = new Author("312331231", "Nahman", "Bialik", 24, Gender.Male);
                Author author2 = new Author("384324391", "Smadar", "Shir", 35, Gender.Female);


                //AuthorsList
                ArrayList AuthorsList1 = new ArrayList();
                AuthorsList1.Add(author1);

                ArrayList AuthorsList2 = new ArrayList();
                AuthorsList2.Add(author1);
                AuthorsList2.Add(author2);


                //Books 
                Book book1 = new Book("Don Quixote", 1999, 100, AuthorsList1, 555, Genre.Horror);
                Book book2 = new Book("Moby Dick", 2015, 80, AuthorsList1, 333, Genre.Action);
                Book book3 = new Book("Kama Sutra", 1995, 80, AuthorsList2, 444, Genre.Comedy);

                //AudioBooks
                Audiobook audiobook1 = new Audiobook("Odyssey", 100, 3.2, 300);
                Audiobook audiobook2 = new Audiobook("harry potter", 100, 1.5, 120);

                //VideoGames
                VideoGame videogame1 = new VideoGame("Starcraft", 300, 40, GameCompanies.Blizzard, Genre.Action, false);
                VideoGame videogame2 = new VideoGame("Warcraft", 200, 42, GameCompanies.Blizzard, Genre.Action, false);
                VideoGame videogame3 = new VideoGame("GTA", 400, 88, GameCompanies.Rockstar, Genre.Comedy, false);

                //TVs
                TV tv1 = new TV("QLED 4K", 4000, ElectronicCompanies.Samsung, 85);
                TV tv2 = new TV("Crystal UHD 4K", 5000, ElectronicCompanies.Samsung, 82);

                //Phones
                Phone Phone1 = new Phone("QLED 4K", 4000, ElectronicCompanies.Samsung, 6.4);
                Phone Phone2 = new Phone("Crystal UHD 4K", 5000, ElectronicCompanies.Samsung, 8.2);

                //Shop
                Shop Amazon = new Shop("Amazon");

                //Add Products
                Amazon.addProduct(book1);
                Amazon.addProduct(book2);
                Amazon.addProduct(book3);
                Amazon.addProduct(audiobook1);
                Amazon.addProduct(audiobook2);
                Amazon.addProduct(videogame1);
                Amazon.addProduct(videogame2);
                Amazon.addProduct(videogame3);
                Amazon.addProduct(tv1);
                Amazon.addProduct(tv2);
                Amazon.addProduct(Phone1);
                Amazon.addProduct(Phone2);

                System.Console.WriteLine(Amazon);



            }
            catch (Exceptions.IllegalArgument e)
            {
                Console.WriteLine(e);
            }

            catch (Exceptions.IllegalAge e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
