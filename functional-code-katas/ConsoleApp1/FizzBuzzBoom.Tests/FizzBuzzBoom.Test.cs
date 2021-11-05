using System.Linq;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(33)]
        [TestCase(69)]
        public void ShouldReturnFizz(int inputNumber)
        {
            var inputs = Enumerable.Empty<int>().Append(inputNumber);
            var results = FizzBuzzBoom.TransformAllNumbers(inputs);
            Assert.AreEqual("Fizz", results.First());
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(55)]
        [TestCase(100)]
        public void ShouldReturnBuzz(int inputNumber)
        {
            var inputs = Enumerable.Empty<int>().Append(inputNumber);
            var results = FizzBuzzBoom.TransformAllNumbers(inputs);
            Assert.AreEqual("Buzz", results.First());
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        [TestCase(45)]
        public void ShouldReturnBoom(int inputNumber)
        {
            var inputs = Enumerable.Empty<int>().Append(inputNumber);
            var results = FizzBuzzBoom.TransformAllNumbers(inputs);
            Assert.That(results.All(x => x == "Boom"));
        }
    }
}