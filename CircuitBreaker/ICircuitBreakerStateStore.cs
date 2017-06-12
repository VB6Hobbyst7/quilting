namespace CircuitBreaker
{
    using System;

    public interface ICircuitBreakerStateStore
    {
        CircuitBreakerState.CircuitBreakerStateEnum State { get; }

        Exception LastException { get; }

        DateTime LastStateChangedDate { get; }

        bool IsClosed { get; }

        void Trip(Exception e);

        void Reset();

        void HalfOpen();
    }
}
