using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool userAgain = true;
            while (userAgain) {

                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.WriteLine("Enter Length(feet):");
                decimal length = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width(feet)");
                decimal width = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height(feet)");
                decimal height = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {length * width} feet");
                Console.WriteLine($"Paremeter: {2 * (length + width)} feet");
                Console.WriteLine($"Volume: {length * width * height} square feet");
                Console.WriteLine("Again? y/n");
                string userContinue = Console.ReadLine();
                if (userContinue == "n")
                userAgain = false;
            }
            Console.WriteLine("Bye.");
        }
    }
}
