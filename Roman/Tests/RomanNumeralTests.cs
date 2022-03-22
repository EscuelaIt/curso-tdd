using System;
using EscuelaIT.TDD.Roman.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace EscuelaIT.TDD.Roman.Tests
{
    public class RomanNumeralTests
    {
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void Control_OnlyPositive(int number)
        {
            Action act = () => new RomanNumeral(number);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Case1()
        {
            ((int)new RomanNumeral("I")).Should().Be(1);
            ((int)new RomanNumeral("II")).Should().Be(2);
            ((int)new RomanNumeral("III")).Should().Be(3);

            ((int)new RomanNumeral("V")).Should().Be(5);
        }
    }
}