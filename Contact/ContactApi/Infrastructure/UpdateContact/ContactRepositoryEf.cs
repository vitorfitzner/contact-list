using ContactApi.Services.CreateOrUpdateContact;
using ContactApi.UpdateContact;

namespace ContactApi.Infrastructure.UpdateContact
{
    public class ContactRepositoryEf : ContactRepository
    {
        public ContactRepositoryEf(ContactDataBase dataBase)
        {
            DataBase = dataBase;
        }

        private ContactDataBase DataBase { get; }

        public override async Task Save(Contact contact)
        {
            DataBase.ContactTable.Update(contact);
            await DataBase.SaveChangesAsync();
        }
    }
}
