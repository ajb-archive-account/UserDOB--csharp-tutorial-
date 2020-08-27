using System;
using System.Globalization;

namespace UserDOB
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var UserDOB = AskForDOB();
        }

        public static void IntroduceSavvy() => Console.WriteLine("Hello, I am Savvy. The worlds worst AI");

        public static DateTimeOffset AskForDOB()
        {
            Console.WriteLine($"Please enter your date of birth in { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

            var userInput = Console.ReadLine();

            var parsedDate = DateTimeOffset.MinValue;

            var dateSuccess = DateTimeOffset.TryParse(userInput, out parsedDate);

            if (dateSuccess)
            {
                return parsedDate;
            }
            else
            {
                Console.WriteLine("That's not a valid date.");

                return AskForDOB(); // Bad idea, Stack Overflow!!
            }


        }
    }
}
