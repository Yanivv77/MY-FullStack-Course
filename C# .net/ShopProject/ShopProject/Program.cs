using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShopProject.Classes;
using ShopProject.Classes.Products.Books;
using ShopProject.Classes.Products.Digital;
using ShopProject.Classes.Products.Electronics;
using ShopProject.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ShopProject
{
    internal class Program
    {

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
            .AddTransient<MyApplication>();
        }

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            MyApplication app = serviceProvider.GetService<MyApplication>();


            try
            {
                app.Start();
                


            }
            catch (Exceptions.IllegalArgument e)
            {
                Console.WriteLine(e);
            }

            catch (Exceptions.IllegalAge e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                app.Stop();
                
            }
            
            Console.ReadLine();
           




        }
    }
}
