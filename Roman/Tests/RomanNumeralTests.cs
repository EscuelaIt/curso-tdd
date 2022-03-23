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
        public void SameSymbols()
        {
            ((int)new RomanNumeral("I")).Should().Be(1);
            ((int)new RomanNumeral("II")).Should().Be(2);
            ((int)new RomanNumeral("III")).Should().Be(3);
            
            ((int)new RomanNumeral("XX")).Should().Be(20);
        }

        [Test]
        public void DifferentSymbols()
        {
            ((int)new RomanNumeral("XV")).Should().Be(15);
            ((int)new RomanNumeral("CLXVI")).Should().Be(166);
        }

        [Test]
        public void OneSymbol()
        {
            ((int)new RomanNumeral("I")).Should().Be(1);
            ((int)new RomanNumeral("V")).Should().Be(5);
            ((int)new RomanNumeral("X")).Should().Be(10);
        }

        [Test]
        public void NotSymbols()
        {
            Action act = () => new RomanNumeral("Ij");
            act.Should().Throw<Exception>();
        }

        [Test]
        public void SubtractiveNotation()
        {
            ((int)new RomanNumeral("IV")).Should().Be(4);
            ((int)new RomanNumeral("IX")).Should().Be(9);
            ((int)new RomanNumeral("XC")).Should().Be(90);
        }

        [Test]
        public void MixedNotation()
        {
            ((int)new RomanNumeral("CLIV")).Should().Be(154);
        }

        [Test]
        public void SubtractiveNotationButIsAlgo()
        {
            Action act = () => new RomanNumeral("IM");
            act.Should().Throw<FormatException>();
        }
    }
}