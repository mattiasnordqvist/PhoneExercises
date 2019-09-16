using System;
using System.Runtime.Serialization;

namespace PhoneExercises
{
    [Serializable]
    internal class BatteryEmptyException : Exception
    {
        public BatteryEmptyException()
        {
        }

        public BatteryEmptyException(string message) : base(message)
        {
        }

        public BatteryEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BatteryEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}