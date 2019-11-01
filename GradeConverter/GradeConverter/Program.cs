using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Converter");

            string cont = "y";
            while (cont.Equals("y"))
            {
                Console.Write("\nEnter numberical grade: ");
                String nbrGradeStr = Console.ReadLine();
                int nbrGrade = Convert.ToInt32(nbrGradeStr);

                String letterGrade = " ";

                if (nbrGrade >= 88) 
                {
                    letterGrade = "A";
                } else if (nbrGrade >= 80)
                {
                    letterGrade = "B";
                } else if (nbrGrade >= 67)
                {
                    letterGrade = "C";
                } else if (nbrGrade >= 60)
                {
                    letterGrade = "D";
                } else
                {
                    letterGrade = "F";
                }

                Console.WriteLine("Letter Grade : " + letterGrade);

                Console.Write("\nContinue? (y/n) ");
                cont = Console.ReadLine();
                
            }

        }
    }
}
