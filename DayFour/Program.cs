using System;

namespace DayFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lowest Value?");
            var lowValue = Console.ReadLine();
            if (!int.TryParse(lowValue, out var lowIntValue))
            {
                throw new ApplicationException($"Not a number: {lowValue}");
            }


            Console.WriteLine("High Value?");
            var highValue = Console.ReadLine();

            if (!int.TryParse(highValue, out var highIntValue))
            {
                throw new ApplicationException($"Not a number: {highValue}");
            }

            var passwordGenerator = new PasswordGenerator(lowIntValue, highIntValue);
            Console.WriteLine($"Part 1: {passwordGenerator.NumberOfPasswords}");
            Console.WriteLine($"Part 2: {passwordGenerator.NumberOfNewPasswords}");
        }
    }
}
