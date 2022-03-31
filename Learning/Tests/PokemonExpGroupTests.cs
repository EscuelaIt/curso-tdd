using System;
using EscuelaIT.TDD.Week.Runtime;
using FluentAssertions;
using NUnit.Framework;

namespace Assets.EscuelaIT.TDD.Week.Tests
{
    public class PokemonExpGroupTests
    {
        [DatapointSource] static IExpGroup[] groups = new IExpGroup[]
        {
            new FastExpGroup(),
            new SlowExpGroup(),
            new MediumSlowExpGroup(),
            new MediumFastExpGroup()
        };
        
        [Theory]
        public void From1To100(IExpGroup sut)
        {
            sut.ExpOf(1).Should().Be(0);
        }

        [Test]
        public void Max()
        {
            new FastExpGroup().ExpOf(100).Should().Be(800000);
            new SlowExpGroup().ExpOf(100).Should().Be(1250000);
            new MediumSlowExpGroup().ExpOf(100).Should().Be(1059860);
            new MediumFastExpGroup().ExpOf(100).Should().Be(1000000);
        }
    }
}