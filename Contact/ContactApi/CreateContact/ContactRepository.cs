using Microsoft.EntityFrameworkCore;

namespace ContactApi.CreateContact
{
    public class ContactRepository : DbContext
    {
        public ContactRepository(DbContextOptions<ContactRepository> opt) : base(opt) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}