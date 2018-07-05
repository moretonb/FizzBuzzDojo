using FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(44, "44")]
        [TestCase(98, "98")]
        public void WhenPassingANumberToOutputGeneratorTheNumberAsAStringIsReturned(int input, string expectedOutput)
        {
            var output = OutputGenerator.Generate(input);
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(99)]
        public void WhenPassingANumberDivisibleByThreeToOutputGeneratorFizzIsReturned(int input)
        {
            const string expectedOutput = "Fizz";
            var output = OutputGenerator.Generate(input);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase(5)]
        [TestCase(100)]
        public void WhenPassingANumberDivisibleByFiveToOutputGeneratorBuzzIsReturned(int input)
        {
            const string expectedOutput = "Buzz";
            var output = OutputGenerator.Generate(input);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase(0)]
        [TestCase(15)]
        [TestCase(90)]
        public void WhenPassingANumberDivisibleByThreeAndFiveToOutputGeneratorFizzBuzzIsReturned(int input)
        {
            const string expectedOutput = "FizzBuzz";
            var output = OutputGenerator.Generate(input);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }
}