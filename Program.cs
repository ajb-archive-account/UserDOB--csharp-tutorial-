using System;
using System.Globalization;

namespace UserDOB
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceDave();

            var UserDOB = AskForDOB();
        }

        public static void IntroduceDave() => Console.WriteLine("Hello, I am Dave. The worlds worst AI");

        public static DateTimeOffset AskForDOB()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Please enter your date of birth in { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                var userInput = Console.ReadLine();

                if (DateTimeOffset.TryParse(userInput, out var parsedDate)) // parse `usereInput` to a (bool) variable.
                    dateOfBirth = parsedDate;
                else
                    Console.WriteLine("That's not a valid date.");
            }
            
            return dateOfBirth;
        }
    }
}

