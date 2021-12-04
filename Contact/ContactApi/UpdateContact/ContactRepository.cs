using Microsoft.EntityFrameworkCore;

namespace ContactApi.UpdateContact
{
    public class ContactRepository : DbContext, IContactRepository
    {
        public ContactRepository(DbContextOptions<ContactRepository> opt) : base(opt) { }

        DbSet<Contact> Contacts { get; set; }

        public async Task Save(Contact contact)
        {
            Contacts.Add(contact);
            await SaveChangesAsync();
        }
    }
}
