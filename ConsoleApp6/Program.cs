using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        // James - So this is a field!  cool use of it.  so basically 
        // any method inside of this program class will have access to this field.
        // by convention, we usually name private fields with an underscore in front of them.
        // so result would be _result
        private static bool result;

        static void Main(string[] args)
        {


            do
            {
                Console.WriteLine("Hello, please enter your name");
                var userName = Console.ReadLine();


                Console.WriteLine("{0} please enter a number from 1 to 100: ", userName);

                string numberGradestring = Console.ReadLine();
                // James - I would initialize this variable closer to where it's going to be used, that would make this 
                // more readable. 
                int numberGrade;
                bool validNUmberGrade = true;

                // James - I see that you are experimenting with two ways of validating but only sticking with one of them.  
                // truth be told I like that you used Regex here, it's good to get experience with it :D 
                bool result = Regex.IsMatch(numberGradestring, "[a-z]");

                // James - just gotta warn you, if this does not parse correctly, your numberGrade WILL = zero. 
                // in this case however, because you are using the result variable to check if it is a valid number, 
                // there is a good chance that this will parse correctly. if any of that is confusing, please do not 
                // hesitate to ask. 
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

                // James - for comparing strings, I would recommend doing something like 
                // 
                // Console.ReadLine().Equals("y", StringComparison.OridinalIgnoreCase), syntax
                // may be off but I'm sure you can figure that out ;)
            } while (Console.ReadLine() == "y"); Console.WriteLine("have a good day");

            Console.ReadKey();
        }
    }
}
