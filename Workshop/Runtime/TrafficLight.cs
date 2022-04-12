using System;

namespace DefaultNamespace
{
    public class TrafficLight : ITrafficLight
    {
        static readonly int States = Enum.GetValues(typeof(TrafficLightState)).Length;
        TrafficLightState state;

        public TrafficLight(TrafficLightState startingLight = TrafficLightState.Green)
        {
            State = startingLight;
        }

        public TrafficLightState State
        {
            get => EmergencyMode ? TrafficLightState.Yellow : state;
            private set => state = value;
        }

        public bool EmergencyMode { get; set; }

        public void Next()
        {
            if(EmergencyMode)
                throw new InvalidOperationException();
            
            var intState = ((int)State + 1 ) % States;
            State = (TrafficLightState)intState;
        }

        public bool IsOn { get; } = true;
    }

    public enum TrafficLightState
    {
        Green,
        Yellow,
        Red
    }
}