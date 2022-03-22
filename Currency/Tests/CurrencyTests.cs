using System;
using EscuelaIT.TDD.Currency.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace EscuelaIT.TDD.Currency.Tests
{
    public class CurrencyTests
    {
        [Test]
        public void MultiplyMoneys()
        {
            var sut = Money.Dollar(5);
            
            sut.Times(2).Should().Be(Money.Dollar(10));
            sut.Times(3).Should().Be(Money.Dollar(15));
        }

        [Test]
        public void Equality()
        {
            Money.Dollar(5).Should().Be(Money.Dollar(5));
            Money.Dollar(5).Should().NotBe(Money.Dollar(6));
            
            Money.Euro(5).Should().Be(Money.Euro(5));
            Money.Euro(5).Should().NotBe(Money.Euro(6));
            
            Money.Dollar(10).Should().NotBe(Money.Euro(10));
        }

        [Test]
        public void Inequality()
        {
            Money.Dollar(5).Should().NotBe(Money.Euro(5));
        }
        
        [Test]
        public void MultiplyEuros()
        {
            var sut = Money.Euro(5);
            
            sut.Times(2).Should().Be(Money.Euro(10));
            sut.Times(3).Should().Be(Money.Euro(15));
        }

        [Test]
        public void FactoryMethods()
        {
            Money.Dollar(1).Times(2).Should().Be(Money.Dollar(2));
            Money.Euro(1).Times(2).Should().Be(Money.Euro(2));
        }
    }
}