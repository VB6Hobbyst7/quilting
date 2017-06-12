namespace CircuitBreaker
{
    public class CircuitBreakerState
    {
        public enum CircuitBreakerStateEnum
        {
            Open,
            HalfOpen,
            Closed
        }
    }
}
