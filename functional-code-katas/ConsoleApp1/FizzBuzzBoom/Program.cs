using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);
            var transformedNumbers = FizzBuzzBoom.TransformAllNumbers(numbers);

            transformedNumbers.ToList().ForEach(Console.WriteLine);
        }
    }
}