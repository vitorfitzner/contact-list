using ContactApi.Infrastructure.UpdateContact;
using ContactApi.Services.CreateOrUpdateContact;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.Infrastructure
{
    public class ContactDataBase : DbContext
    {
        public ContactDataBase(DbContextOptions<ContactDataBase> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactEntityMap());
        }

        public DbSet<Contact> ContactTable { get; }
    }
}
