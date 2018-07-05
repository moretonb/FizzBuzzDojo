using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var output = OutputGenerator.Generate(i);
                Console.WriteLine(output);
            }
        }
    }

    public class OutputGenerator
    {
        public static string Generate(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return Convert.ToString(number);
        }
    }
}
