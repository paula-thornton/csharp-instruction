using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();  // print a blank line

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                String fahrStr = Console.ReadLine();
                double fahrNbr = Convert.ToDouble(fahrStr);
                
                double celsiusTemp = (fahrNbr - 32) * 5 / 9;
                double roundTemp = Math.Round(celsiusTemp, 2) * 100 / 100;
              //Console.WriteLine("d3 rounded to 2 digits: " + Math.Round(d3, 2));
                Console.WriteLine("Degrees in Celsius: " + celsiusTemp);
                Console.WriteLine("Celsius Temp Rounded: " + roundTemp);

                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();

            }
        }
    }
}
