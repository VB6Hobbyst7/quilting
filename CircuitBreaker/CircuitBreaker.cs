using System;
using System.Threading;

namespace CircuitBreaker
{
    public class CircuitBreaker
    {
        private readonly ICircuitBreakerStateStore _stateStore = CircuitBreakerStateStoreFactory.GetCircuitBreakerStateStore();

        private readonly object HalfOpenSyncObject = new object();

        private readonly DateTime OpenToHalfOpenWaitTime = new DateTime(0, 0, 0, 0, 0, 30);

        public bool IsClosed
        {
            get
            {
                return _stateStore.IsClosed;
            }
        }

        public bool IsOpen
        {
            get
            {
                return !IsClosed;
            }
        }

        public void ExecuteAction(Action action)
        {
            if(IsOpen)
            {
                if(_stateStore.LastStateChangedDate.AddTicks(OpenToHalfOpenWaitTime.Ticks) < DateTime.UtcNow)
                {
                    bool lockTaken = false;

                    try
                    {
                        Monitor.TryEnter(HalfOpenSyncObject, ref lockTaken);

                        if (lockTaken)
                        {
                            _stateStore.HalfOpen();

                            action();

                            _stateStore.Reset();

                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        _stateStore.Trip(ex);

                        throw;
                    }
                    finally
                    {
                        if(lockTaken)
                        {
                            Monitor.Exit(HalfOpenSyncObject);
                        }
                    }
                }

                throw new CircuitBreakerOpenException(_stateStore.LastException);
            }

            try
            {
                action();
            }
            catch(Exception ex)
            {
                TrackException(ex);

                throw;
            }
        }

        private void TrackException(Exception ex)
        {
            _stateStore.Trip(ex);
        }
    }
}
