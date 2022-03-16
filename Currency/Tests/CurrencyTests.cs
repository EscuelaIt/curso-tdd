using System;
using EscuelaIT.TDD.Currency.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace EscuelaIT.TDD.Currency.Tests
{
    public class CurrencyTests
    {
        [Test]
        public void MultiplyDollars()
        {
            var sut = new Dollar(5);
            
            sut.Times(2).Should().Be(new Dollar(10));
            sut.Times(3).Should().Be(new Dollar(15));
        }

        [Test]
        public void Equality()
        {
            new Dollar(5).Should().Be(new Dollar(5));
            new Dollar(5).Should().NotBe(new Dollar(6));
            
            new Euro(5).Should().Be(new Euro(5));
            new Euro(5).Should().NotBe(new Euro(6));
        }

        [Test]
        public void Inequality()
        {
            new Dollar(5).Should().NotBe(new Euro(5));
        }
        
        [Test]
        public void MultiplyEuros()
        {
            var sut = new Euro(5);
            
            sut.Times(2).Should().Be(new Euro(10));
            sut.Times(3).Should().Be(new Euro(15));
        }

        [Test]
        public void METHOD()
        {
            Money sut = new Dollar(10);
            var result = sut.Should().NotBe(new Euro(10));
        }
    }
}