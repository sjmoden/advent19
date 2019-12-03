using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DayThree
{
    class Program
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

            var wires = new List<Wire>();
            foreach (var line in lines)
            {
                var wire = new Wire();
                wire.MoveUsingString(line);
                wires.Add(wire);
            }

            Console.WriteLine(
                $"Part 1: {WireComparer.MinimumTaxicabDistance(wires.First().CoOrdinates, wires.Last().CoOrdinates)}");



            Console.WriteLine($"Part 2: {WireComparer.MinimumStepToPoint(wires.First().CoOrdinates, wires.Last().CoOrdinates)}");
        }
    }
}
