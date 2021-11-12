using ConsoleCalculator.Classes;
using ConsoleCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    class Program
    {
        private static ILogger<Program> _logger;
        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            _serviceProvider = new ServiceCollection()
                .AddLogging(options =>
                {
                    options.AddConsole();
                    options.SetMinimumLevel(LogLevel.Information);
                })
                .AddSingleton<IVehicleDataReader, VehicleDataReader>()
                .BuildServiceProvider();

            _logger = _serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            _logger.LogInformation("Starting application");

            //_logger = loggerFactory.CreateLogger<Program>();

            //_logger.LogInformation("Hello World!");

            //IfExample();

            //ForeachExample();

            //int sum = CalculateSumOfNumbersTill(100);
            //_logger.LogInformation($"Sum is {sum}");
            //sum = WhileExample(sum);
            //sum = DoWhileExample(sum);

            List<Vehicle> vehicles = new List<Vehicle>();
            try
            {
                Car car1 = new Car(_serviceProvider.GetService<IVehicleDataReader>(), "red", "2022", 4);
                car1.MoveForward();
                car1.Break();
                string color = car1.Color;
                vehicles.Add(car1);

                Vehicle vehicle2 = new Vehicle(_serviceProvider.GetService<IVehicleDataReader>(), "blue", "2011");
                vehicle2.MoveForward();
                vehicles.Add(vehicle2);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            //vehicles.Add(new Vehicle("blue"));
            //vehicles.Add(new Vehicle() { Color = "green" });
            //vehicles.Add(new Vehicle(color));

            foreach (Vehicle vehicle in vehicles)
            {
                _logger.LogInformation(vehicle.ToString());
            }

            Console.ReadKey();
        }

        private static int DoWhileExample(int sum = 0)
        {
            int num = 10;
            do
            {
                sum += num;
                num++;
            } while (num < 10);
            _logger.LogDebug(sum.ToString());
            return sum;
        }

        private static int WhileExample(int sum = 0)
        {
            int num = 10;
            while (num < 10)
            {
                sum += num;
                num++;
            }
            _logger.LogDebug(sum.ToString());
            return sum;
        }

        private static void ForeachExample()
        {
            List<string> fruits = new List<string>
            {
                "Apple",
                "Banana",
                "Grape",
                "Passionfruit",
                "Lemon"
            };

            foreach (string fruit in fruits)
            {
                _logger.LogInformation(fruit);
            }
        }

        private static int CalculateSumOfNumbersTill(int tillNumber)
        {
            int sum = 0;
            for (int i = 0; i < tillNumber; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        private static void IfExample()
        {
            bool IsSunday = DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
            if (IsSunday)
            {
                _logger.LogInformation("Sunday");
            }
            else
            {
                _logger.LogInformation("Not sunday");
            }
        }
    }

}
