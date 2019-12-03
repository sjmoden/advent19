using System;
using System.IO;

namespace DayTwo
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

            var startingMemory = File.ReadAllText(fileLocation);
            var computer = new IntComputerWrapper(12,2,startingMemory);
            Console.WriteLine($"Part1:{computer.FirstCharacter}");

            var nounAndVerbFinder = new NounAndVerbLocator(startingMemory);
            Console.WriteLine($"Part2: {nounAndVerbFinder.FindNounVerbValue(19690720)}");
        }
    }
}
