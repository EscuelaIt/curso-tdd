using System;

namespace DefaultNamespace
{
    public class TrafficLightTimer : ITrafficLight
    {
        readonly TimeSpan blinkCooldown;
        
        TimeSpan currentTime;
        readonly TrafficLight model;
        
        public TrafficLightTimer()
        {
            blinkCooldown = TimeSpan.FromSeconds(1);
            currentTime = TimeSpan.Zero;

            model = new TrafficLight();
        }
        
        public TrafficLightTimer(TimeSpan blinkCooldown)
        {
            this.blinkCooldown = blinkCooldown;
            currentTime = TimeSpan.Zero;

            model = new TrafficLight();
        }
        
        public void InjectTime(TimeSpan time)
        {
            currentTime += time;
            if(currentTime <= blinkCooldown)
                return;
            
            currentTime = TimeSpan.Zero;
            IsOn = !IsOn;
            model.Next();
        }

        public bool IsOn { get; private set; } = true;

        public bool EmergencyMode
        {
            get => model.EmergencyMode;
            set => model.EmergencyMode = value;
        }

        public TrafficLightState State => model.State;
    }
}