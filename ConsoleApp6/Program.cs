using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        private static bool result;

        static void Main(string[] args)
        {


            do
            {
                Console.WriteLine("Hello, please enter your name");
                var userName = Console.ReadLine();


                Console.WriteLine("{0} please enter a number from 1 to 100: ", userName);

                string numberGradestring = Console.ReadLine();
                int numberGrade;
                bool validNUmberGrade = true;


                bool result = Regex.IsMatch(numberGradestring, "[a-z]");

                bool validNumberGrade = int.TryParse(numberGradestring, out numberGrade);
                if (result != false)
                {
                    Console.WriteLine("Please enter a valid number");
                }


                if (numberGrade % 2 != 0)
                {
                    Console.WriteLine("That is odd {0}", userName);
                }

                if (numberGrade % 2 == 0 && (numberGrade >= 2 && numberGrade <= 25))
                {
                    Console.WriteLine("{0} that is even and less than 25", userName);

                }
                if (numberGrade % 2 == 0 && numberGrade >= 26 && numberGrade <= 60)
                {
                    Console.WriteLine("{0}, that is even", userName);

                }
                if (numberGrade % 2 == 0 && numberGrade >= 61)
                {
                    Console.WriteLine("{0}, {1} is even", userName, numberGrade);

                }

                if (numberGrade % 2 != 0 && numberGrade >= 61)
                {
                    Console.WriteLine("{0}, {1} is odd", userName, numberGrade);

                }



                Console.WriteLine("Would you like to continue? y/n", userName);

            } while (Console.ReadLine() == "y"); Console.WriteLine("have a good day");

            Console.ReadKey();
        }
    }
}
