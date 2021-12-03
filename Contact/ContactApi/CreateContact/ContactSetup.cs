using ContactApi.CreateContact;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ContactSetup
    {
        public static IServiceCollection AddCreateContact(this IServiceCollection services)
        {
            services.AddScoped<ICreateContactService, ContactService>();

            services.AddDbContext<ContactRepository>(opt => opt.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            return services;
        }
    }
}
