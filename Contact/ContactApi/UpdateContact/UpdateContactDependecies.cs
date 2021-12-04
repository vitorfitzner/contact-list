using Microsoft.EntityFrameworkCore;

namespace ContactApi.UpdateContact
{
    public static class UpdateContactDependecies
    {
        public static IServiceCollection AddUpdateContact(this IServiceCollection services)
        {
            services.AddScoped<IUpdateContactService, UpdateContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddDbContext<ContactRepository>(options => options.UseSqlServer(""));

            return services;
        }
    }
}
