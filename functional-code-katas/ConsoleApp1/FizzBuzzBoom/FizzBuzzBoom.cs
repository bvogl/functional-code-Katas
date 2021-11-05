using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public static class FizzBuzzBoom
    {
        public static IEnumerable<string> TransformAllNumbers(IEnumerable<int> numbers)
        {
            return numbers.Select((x) => GetStringForInput(x));
        }

        private static string GetStringForInput(int number)
        {
            var result = number % 3 == 0 && number % 5 == 0 ? "Boom"
                : number % 3 == 0 ? "Fizz"
                : number % 5 == 0 ? "Buzz"
                : number.ToString();

            return result;
        }
    }
}