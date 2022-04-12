using System;
using FluentAssertions;
using NUnit.Framework;

namespace DefaultNamespace
{
    public class Iso8583Tests
    {
        [TestCase("0", "0")]
        [TestCase("1", "1")]
        [TestCase("11", "3")]
        [TestCase("111", "7")]
        [TestCase("1010", "A")]
        [TestCase("10100", "14")]
        public void Bitmap_In_Out(string origin, string expected)
        {
            var sut = new Iso8583Bitmap(origin);
            sut.Hex.Should().Be(expected);
        }

        [Test]
        public void METHOD()
        {
            Action act = () => new Iso8583Bitmap("00000000000000000100000000000000");
            act.Should().Throw<ArgumentException>();
        }
    }
}