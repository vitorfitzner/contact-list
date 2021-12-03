namespace ContactApi.CreateContact
{
    internal class ContactService : ICreateContactService
    {
        public ContactService(ContactRepository repository)
        {
            Repository = repository;
        }

        public ContactRepository Repository { get; }

        public async Task<(string[] errors, Guid contactId)> Create(ContactDto contact)
        {
            var (isValid, errors) = contact.Validate();

            if (errors.Any())
                return (errors, default(Guid));

            Contact entity = new();
            entity.Id = Guid.NewGuid();
            entity.Name = contact.Name;
            entity.Email = contact.Email;
            entity.PhoneNumber = contact.PhoneNumber;

            Repository.Contacts.Add(entity);
            await Repository.SaveChangesAsync();

            return (errors, entity.Id);
        }
    }
}