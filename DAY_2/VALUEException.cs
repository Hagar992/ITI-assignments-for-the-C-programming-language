using System;
using System.Runtime.Serialization;

namespace Task_2_iti_
{
    [Serializable]
    internal class VALUEException : Exception
    {
        public VALUEException()
        {
        }

        public VALUEException(string message) : base(message)
        {
        }

        public VALUEException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VALUEException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}