using EscuelaIT.TDD.FizzBuzz.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace System
{
    public class FizzBuzzTests
    {
        [Test]
        public void DefaultCases()
        {
            FizzBuzz.Of(1).Should().Be("1");
            FizzBuzz.Of(2).Should().Be("2");
            FizzBuzz.Of(15).Should().Be("FizzBuzz");
            FizzBuzz.Of(30).Should().Be("FizzBuzz");
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzCases(int number)
        {
            FizzBuzz.Of(number).Should().Be("Fizz");
        }
        
        [TestCase(5)]
        [TestCase(10)]
        public void BuzzCases(int number)
        {
            FizzBuzz.Of(number).Should().Be("Buzz");
        }

        [Test]
        public void FizzBuzz_Format()
        {
            var sut = new FizzBuzzFormat(3, "Fizz");

            sut.Of(3).Should().Be("Fizz");
        }
    }
}