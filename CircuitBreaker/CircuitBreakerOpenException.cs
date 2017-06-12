using System;
using System.Runtime.Serialization;

namespace CircuitBreaker
{
    [Serializable]
    public class CircuitBreakerOpenException : Exception
    {
        private Exception lastException;

        public CircuitBreakerOpenException()
        {
        }

        public CircuitBreakerOpenException(Exception lastException)
        {
            this.lastException = lastException;
        }

        public CircuitBreakerOpenException(string message) : base(message)
        {
        }

        public CircuitBreakerOpenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CircuitBreakerOpenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}