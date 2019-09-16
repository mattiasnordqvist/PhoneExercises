using System;
using System.Collections.Generic;

namespace PhoneExercises
{
    public class Phone
    {
        //readonly property can only be set initially or through constructor
        public string Model { get; }
        public string Manufacturer { get; }
        public Screen Screen { get; }
        public Battery Battery { get; }

        public List<Call> CallHistory { get; } = new List<Call>();

        public Phone(string model, string manufacturer, Screen screen, Battery battery)
        {
            Model = model ?? throw new ArgumentException("Model cannot be null");
            Manufacturer = manufacturer ?? throw new ArgumentException("Manufacturer cannot be null");
            Screen = screen ?? throw new ArgumentException("Screen cannot be null");
            Battery = battery ?? throw new ArgumentException("Battery cannot be null");
        }
        private Call onGoingCall = null;
        public Call MakeCall(PhoneNumber number)
        {
            if (Battery.ChargeLevel > 0)
            {
                onGoingCall = new Call(number);
                return onGoingCall;
            }
            else
            {
                throw new BatteryEmptyException();
            }
        }

        /// <summary>
        /// Does nothing if MakeCall has not been invoked before.
        /// </summary>
        public void HangUp()
        {
            if (onGoingCall != null)
            {
                CallHistory.Add(onGoingCall);
                onGoingCall.HangUp();
            }
            onGoingCall = null;
        }

        public int CallCount()
        {
            return CallHistory.Count;
        }

        public TimeSpan TotalCallDuration()
        {
            var totalDuration = TimeSpan.FromSeconds(0);
            foreach(var call in CallHistory)
            {
                totalDuration += call.Duration;
            }
            return totalDuration;
        }
    }

}