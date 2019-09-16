using System;

namespace PhoneExercises
{
    public class Call
    {
        public PhoneNumber Destination { get; }
        public DateTime Start { get; }
        public bool OnGoing { get; private set; }
        
        private TimeSpan duration;

        public TimeSpan Duration
        {
            get
            {
                if (OnGoing)
                {
                    return DateTime.Now - Start;
                }
                else
                {
                    return duration;
                }
            }
        }


        public Call(PhoneNumber phoneNumber)
        {
            Destination = phoneNumber;
            OnGoing = true;
            Start = DateTime.Now;
        }


        public void HangUp()
        {
            duration = Duration;
            OnGoing = false;
        }
    }
}