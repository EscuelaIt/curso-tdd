using System;
using FluentAssertions;
using NUnit.Framework;
using static DefaultNamespace.TrafficLightState;

namespace DefaultNamespace
{
    public class TrafficLightTests
    {
        [Test]
        public void ColorFlow()
        {
            var trafficLight = new TrafficLight(Green);
            trafficLight.Next();
            Assert.AreEqual(trafficLight.State, Yellow);
            trafficLight.Next();
            Assert.AreEqual(trafficLight.State, Red);
            trafficLight.Next();
            Assert.AreEqual(trafficLight.State, Green);
        }

        [Test]
        public void EmergencyMode_IsYellow()
        {
            var sut = new TrafficLight
            {
                EmergencyMode = true
            };

            sut.State.Should().Be(Yellow);
        }

        [Test]
        public void AfterEmergencyMode_IsBackToItsColor()
        {
            var sut = new TrafficLight(Red)
            {
                EmergencyMode = true
            };

            sut.EmergencyMode = false;
            sut.State.Should().Be(Red);
        }

        [Test]
        public void IfNext_DuringEmergenceMode_ThrowPrecondition()
        {
            var sut = new TrafficLight()
            {
                EmergencyMode = true
            };

            Action act = () => sut.Next();

            act.Should().Throw<Exception>();
        }

        [Test]
        public void TrafficLight_IsAlwaysOn()
        {
            var sut = new TrafficLight();
            sut.IsOn.Should().BeTrue();
            sut.Next();
            sut.IsOn.Should().BeTrue();
            sut.EmergencyMode = true;
            sut.IsOn.Should().BeTrue();
        }
    }
}