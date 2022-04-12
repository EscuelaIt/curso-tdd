namespace DefaultNamespace
{
    public interface ITrafficLight
    {
        bool IsOn { get; }
        bool EmergencyMode { get; set; }
        TrafficLightState State { get; }
    }
}