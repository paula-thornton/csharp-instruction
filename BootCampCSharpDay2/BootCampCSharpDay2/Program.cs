using System;

// these are the same for java and c sharp:
// if a method is static, it can only call static methods
// do not have to declare an instance to access static methods
// have to declare an instance to access non-static methods;

namespace BootCampCSharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Day 2!");

            Console.WriteLine("Enter an integer: ");
            int nbr = GetNbr();

            switch (nbr)
            {
                case 1:
                    Console.WriteLine("1 entered.");
                    break;
                case 2:
                    Console.WriteLine("2 entered.");
                    break;
                case 3:
                    Console.WriteLine("3 entered.");
                    break;
                default:
                    Console.WriteLine("Number > 3");
                    break;
            }

            Console.WriteLine("for loop w/ index...");
            for (int i = 0; i < nbr; i++)
            {
                Console.WriteLine(i);
            }

            printThreeNumbers(1,3,5);
            printThreeNumbers();
            printThreeNumbers(1);
            printThreeNumbers(1,3);
            printThreeNumbers(1, n3: 5);

        }

        private static int GetNbr()
        {
            int nbr = 0;
            try
            {
                nbr = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(e.ToString());
            }
            return nbr;
        }
        private static void printThreeNumbers( int n1 = 5, int n2 = 10, int n3 = 15)
        {
            Console.WriteLine("3 nbrs: " + n1 + " " + n2 + " " + n3);
        }
    }
}
