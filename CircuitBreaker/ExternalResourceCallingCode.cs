using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitBreaker
{
    public class ExternalResourceCallingCode
    {
        public void CallResource()
        {
            var breaker = new CircuitBreaker();

            try
            {
                breaker.ExecuteAction(() =>
                {
                    //Call an external resource
                });
            }
            catch(CircuitBreakerOpenException ex)
            {
                //Catch the circuit breaker open exception
            }
            catch(Exception ex)
            {
                //Catch other exceptions
            }
        }
    }
}
