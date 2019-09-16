namespace PhoneExercises
{
    public class Battery
    {
        public string Model { get; }
        public int Capacity { get; }
        public int ChargeLevel { get; }
        public BatteryType BatteryType { get; }
        public Battery(string model, BatteryType type, int capacity)
        {
            Model = model;
            Capacity = capacity;
            ChargeLevel = 70;
            BatteryType = type;
        }
    }
}