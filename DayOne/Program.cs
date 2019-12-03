using System;
using System.IO;

namespace DayOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where is the file located?");
            var fileLocation = Console.ReadLine();

            if (!File.Exists(fileLocation))
            {
                Console.WriteLine("File not found!");
                return;
            }
            var lines = File.ReadAllLines(fileLocation);
            var fuelTotal = 0;
            var totalFuelTotal = 0;
            foreach (var line in lines)
            {
                if (!int.TryParse(line, out var mass))
                {
                    Console.WriteLine($"Warning: An Entry in the file is not an int:{line}");
                    continue;
                }
                var rocketModule = new RocketModule(mass);
                fuelTotal += rocketModule.FuelRequired;
                totalFuelTotal += rocketModule.TotalFuelRequired;
            }

            Console.WriteLine(fuelTotal);
            Console.WriteLine(totalFuelTotal);
        }
    }
}
