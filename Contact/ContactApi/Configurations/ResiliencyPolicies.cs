using Polly;
using Polly.Extensions.Http;
using Serilog;
using static Polly.Extensions.Http.HttpPolicyExtensions;

namespace ContactApi.Policies
{
    public static class PoliciesConfiguration
    {
        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HandleTransientHttpError()
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromMilliseconds(Math.Pow(1.5, retryAttempt) * 1000),
                (_, waitingTime) =>
                {
                    Log.Logger.Information("----- Retrying in {WaitingTime}s", $"{ waitingTime.TotalSeconds:n1}");
                });
        }

        public static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HandleTransientHttpError()
            .CircuitBreakerAsync(15, TimeSpan.FromSeconds(15));
        }
    }


    public static class ExceptionConfiguration
    {
        
    }
}
