using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How old are you?");
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
            try
            {
                if (age < 0) throw new NegativeAgeException();
                if (age == 0) throw new BabyException();
                int year = DateTime.Now.Year;
                Console.WriteLine("Is your birthday today, or was it earlier this year?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    Console.WriteLine("You were born in {0}.", year - age);
                    Console.ReadKey();
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("You were born in {0}.", year - age - 1);
                    Console.ReadKey();
                }
                else
                {
                    throw new InvalidAnswerException();
                }
            }
            catch (NegativeAgeException)
            {
                Console.WriteLine("Seriously?? You haven't been born yet?");
                Console.ReadKey();
                return;
            }
            catch (BabyException)
            {
                Console.WriteLine("You're a baby. I should tell you when you were born, but I won't");
                Console.ReadKey();
                return;
            }
            catch (InvalidAnswerException)
            {
                Console.WriteLine("You gave an invalid answer.\nThe program will now close");
                Console.ReadKey();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Sorry.\nThe program will now close");
                Console.ReadKey();
                return;
            }



        }
    }
}
