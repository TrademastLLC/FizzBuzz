using System;
using System.Collections.Generic;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Fizz");
            dict.Add(5, "Buzz");

            foreach (string output in fb.Numbers(int.MaxValue, dict))
            {
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
