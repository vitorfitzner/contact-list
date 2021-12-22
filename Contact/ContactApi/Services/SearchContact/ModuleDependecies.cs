using ContactApi.UpdateContact;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ModuleDependecies
    {
        public static IServiceCollection AddSearchContact(this IServiceCollection services)
        {
            services.AddScoped<ContactService>();

            return services;
        }
    }
}
