using System;
using EscuelaIT.TDD.Week.Runtime;
using FluentAssertions;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace Assets.EscuelaIT.TDD.Week.Tests
{
    public class EndOfTheWeekTests
    {
        [DatapointSource]
        static DateTime[] EqClassesDays => new[]
        {
            21.March(2022).At(00, 00, 00, 001),
            21.March(2022).At(00, 00, 00),
            21.March(2022).At(00, 00, 01), 
            22.March(2022).At(08, 00, 13),
            23.March(2022).At(00, 00, 01),
            24.March(2022).At(23, 59, 59),
            25.March(2022).At(12, 59, 59),
            26.March(2022).At(13, 00, 00),
            27.March(2022).At(00, 00, 00),
            27.March(2022).At(23, 59, 59),
            27.March(2022).At(23, 59, 59, 999),
        };
        
        [Theory]
        public void AfterNow(DateTime aTime)
        {
            aTime.EndOfTheWeek().Should().BeAfter(aTime);
        }

        [Theory]
        public void EndsAtMondayMidnight(DateTime aTime)
        {
            aTime.EndOfTheWeek().TimeOfDay.Should().Be(TimeSpan.Zero);
            aTime.EndOfTheWeek().DayOfWeek.Should().Be(DayOfWeek.Monday);
        }

        [Theory]
        public void NeverGreaterThanAWeek(DateTime aTime)
        {
            (aTime.EndOfTheWeek() - aTime).Days.Should().BeLessOrEqualTo(7);
        }
    }
}