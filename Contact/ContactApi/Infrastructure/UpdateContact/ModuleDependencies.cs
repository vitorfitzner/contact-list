using ContactApi.Infrastructure.UpdateContact;
using ContactApi.UpdateContact;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ContactApi.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ModuleDependencies
    {
        public static IServiceCollection AddContactApiInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ContactRepository, ContactRepositoryEf>();

            services.Configure<ContactDatabaseOptions>(configuration.GetSection(ContactDatabaseOptions.SectionName));

            services.AddDbContext<ContactDataBase>(opt => opt.UseSqlServer(""));

            return services;
        }
    }

    public class ContactDatabaseOptions
    {
        public const string SectionName = "ContactDatabase";
        public string ConnectionString { get; set; } = string.Empty;
    }
}
