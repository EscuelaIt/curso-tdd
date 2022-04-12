using System;
using FluentAssertions;
using NUnit.Framework;

namespace DefaultNamespace
{
    public class TrafficLightTimerTests
    {
        [Test]
        public void ByDefault_IsOn()
        {
            var trafficLightTimer = new TrafficLightTimer();
            trafficLightTimer.IsOn.Should().BeTrue();
        }

        [Test]
        public void WhenOnEmergency_AfterNTime_Blinks()
        {
            var timer = new TrafficLightTimer(TimeSpan.FromSeconds(.75f));
            timer.IsOn.Should().BeTrue();
            timer.EmergencyMode = true;
            timer.InjectTime(TimeSpan.FromSeconds(1));
            timer.IsOn.Should().BeFalse();
            timer.InjectTime(TimeSpan.FromSeconds(1));
            timer.IsOn.Should().BeTrue();
        }

        [Test]
        public void InjectingCooldownTime_ThenStateChanges()
        {
            var timer = new TrafficLightTimer(TimeSpan.FromSeconds(.75f));
            timer.State.Should().Be(TrafficLightState.Green);
            timer.InjectTime(TimeSpan.FromSeconds(1f));
            timer.State.Should().Be(TrafficLightState.Yellow);
            timer.InjectTime(TimeSpan.FromSeconds(0.01f));
            timer.State.Should().Be(TrafficLightState.Yellow);
        }
    }
}