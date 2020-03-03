using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]

    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]



        public void FizzBuzzer_GivenInt_ReturnsString(int input, string expected)

        {
            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

