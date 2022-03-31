using System;
using EscuelaIT.TDD.Week.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace Assets.EscuelaIT.TDD.Week.Tests
{
    public class RandomGeneratorTests
    {
        [DatapointSource]
        static IRandomGenerator[] generators => new IRandomGenerator[]
        {
            new SystemRandomAdapter(),
            new UnityRandomAdapter()
        };
        
        [Theory]
        public void SameNumber(IRandomGenerator sut)
        {
            sut.Next(4, 4).Should().Be(4);
        }

        [Theory]
        public void OneNumber(IRandomGenerator sut)
        {
            sut.Next(4, 5).Should().Be(4);
        }
        
        [Theory]
        public void Range(IRandomGenerator sut)
        {
            sut.Next(4, 6).Should().BeOneOf(4, 5);
        }
        
        [Theory]
        public void RangeInverted(IRandomGenerator sut)
        {
            sut.Next(10, 1).Should().BeInRange(1, 10);
        }
        
        [Theory]
        public void RangeOfOneInverted(IRandomGenerator sut)
        {
            sut.Next(2, 1).Should().Be(1);
        }
    }
}