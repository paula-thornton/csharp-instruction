using System;

namespace Ch4TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();  // print a blank line

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter an integer:  ");
                String response = Console.ReadLine();
                int inputInt = Convert.ToInt32(response);
               
                Console.WriteLine("Number  Squared Cubed");
                Console.WriteLine("======  ======= ======");

                for (int i = 1; i <= inputInt; i++)
                {
                    int iSquared = i * i;
                    int iCubed = i * i * i;
                    Console.WriteLine(i + "\t" + iSquared + "\t" + iCubed);
                }

                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
        }
	
    }
}
