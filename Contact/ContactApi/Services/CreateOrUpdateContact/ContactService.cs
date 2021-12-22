using ContactApi.Services.ContactAggregate;

namespace ContactApi.UpdateContact
{
    public class ContactService
    {
        public ContactService(ContactRepository repository)
        {
            Repository = repository;
        }

        private ContactRepository Repository { get; }

        public virtual async Task<(string[] errors, bool newContactCreated)> CreateOrUpdate(ContactModel contact)
        {
            var entity = new Contact
            {
                ContactId = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber
            };

            var validation = entity.Validate();

            if (validation.Succeeded) 
                await Repository.Save(entity);

            return (validation.Errors, true);
        }
    }
}
