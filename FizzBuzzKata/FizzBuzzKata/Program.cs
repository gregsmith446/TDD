using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance
            FizzBuzzer fb = new FizzBuzzer();

            // create input data 0 through 100 + print result
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fb.FizzBuzz(i)); 
            }
        }
    }

    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            string result = String.Empty;

            if (input % 3 == 0)
            {
                result = "Fizz";
            }
            if (input % 5 == 0)
            {
                result = result + "Buzz";
            }
            if (result == String.Empty)
            {
                result = input.ToString();
            }
            return result;
        }
    }
}
