using System;

namespace BootCampCSharpDay1                // folder
{
    class Program                           //  Public assumed by default? 
    {
        static void Main(string[] args)     // Method name starts with capital
        {

            Console.WriteLine("Welcome to C# day 1!");
            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine("sum = " + sum);

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("In a while loop...");
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine("choice = " + choice);
            }

            if (sum > 10)
            {
                Console.WriteLine("Sum > 10");
            } else {
                Console.WriteLine("Sum <= 10");
            }

            Console.Write("Enter a number: ");
            String nbrStr = Console.ReadLine();
            int nbr = Convert.ToInt32(nbrStr);
            Console.WriteLine("nbr = " + nbr);

            double d1 = 4.5;
            double d2 = 5.3;
            int sum2 = (int)(d1 + d2);
            double sum3 = d1 + d2;
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);

            Random random = new Random();
            int r1 = random.Next();
            Console.WriteLine("r1 = " + r1);

            int r2 = random.Next(10) + 1;  // Add 1 since random w/ parm 10 will return 0-9
            Console.WriteLine("r2 = " + r2);

            while (r2 != 10)
            {
                r2 = random.Next(10) + 1;
                Console.WriteLine("r2 = " + r2);
            }

            double d3 = 75.8899974382;
            Console.WriteLine("d3 = " + d3);
            Console.WriteLine("d3 rounded: " + Math.Round(d3));     // to whole number
            Console.WriteLine("d3 rounded to 2 digits: " + Math.Round(d3, 2));  // to 2 digits

            double price = 15.99;
            Console.WriteLine("price = " + price);
            Console.WriteLine("price formatted " + price.ToString("C2"));

            double pct = .03467;
            Console.WriteLine("pct = " + pct);
            Console.WriteLine("percent formatted " + pct.ToString("P3"));




            Console.WriteLine("Bye");
        }
    }
}
