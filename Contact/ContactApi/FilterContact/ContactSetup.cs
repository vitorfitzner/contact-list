using ContactApi.FilterContact;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FilterContactSetup
    {
        public static IServiceCollection AddFilterContact(this IServiceCollection services)
        {
            services.AddScoped<IFilterContactService, FilterContactService>();

            return services;
        }
    }
}
