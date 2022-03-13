using EscuelaIT.TDD.Roman.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace EscuelaIT.TDD.Roman.Tests
{
    public class FizzBuzzTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        public void NormalCases(int number)
        {
            new FizzBuzz().Of(number).Should().Be(number.ToString());
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(333)]
        public void FizzCases(int number)
        {
            new FizzBuzz().Of(number).Should().Be("FIZZ!");
        }

        [TestCase(5)]
        [TestCase(10)]
        public void BuzzCases(int number)
        {
            new FizzBuzz().Of(number).Should().Be("BUZZ!");
        }

        [TestCase(15)]
        [TestCase(300)]
        public void FizzBuzzCases(int number)
        {
            new FizzBuzz().Of(number).Should().Be("FIZZBUZZ!");
        }

        [TestCase(1, "1")]
        [TestCase(2, "1, 2")]
        [TestCase(3, "1, 2, FIZZ!")]
        [TestCase(4, "1, 2, FIZZ!, 4")]
        [TestCase(5, "1, 2, FIZZ!, 4, BUZZ!")]
        [TestCase(6, "1, 2, FIZZ!, 4, BUZZ!, FIZZ!")]
        public void Sequence(int number, string expected)
        {
            new FizzBuzz().UpTo(number).Should().Be(expected);
        }
    }
}