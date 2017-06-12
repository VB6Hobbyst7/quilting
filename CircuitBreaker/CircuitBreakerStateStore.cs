namespace CircuitBreaker
{
    using System;

    public class CircuitBreakerStateStore : ICircuitBreakerStateStore
    {
        public CircuitBreakerState.CircuitBreakerStateEnum State { get; }

        public Exception LastException { get; }

        public DateTime LastStateChangedDate { get; }

        public bool IsClosed { get; }

        public void HalfOpen()
        {
        }

        public void Reset()
        {
        }

        public void Trip(Exception e)
        {
        }
    }
}
