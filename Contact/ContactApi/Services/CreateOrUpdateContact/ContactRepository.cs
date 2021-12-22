using ContactApi.Services.CreateOrUpdateContact;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.UpdateContact
{
    public abstract class ContactRepository
    {
        public abstract Task Save(Contact contact);
    }
}
