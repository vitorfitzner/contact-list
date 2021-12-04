namespace ContactApi.UpdateContact
{
    public class UpdateContactService : IUpdateContactService
    {
        public UpdateContactService(IContactRepository repository)
        {
            Repository = repository;
        }

        public IContactRepository Repository { get; }

        public async Task<(bool updateSucceeded, string[] errors)> Update(ContactDto contact)
        {
            Contact entity = new();
            entity.Id = contact.Id;
            entity.Name = contact.Name;
            entity.Email = contact.Email;
            entity.PhoneNumber = contact.PhoneNumber;
            entity.CreatedAt = DateTime.UtcNow;

            var validation = entity.Validate();

            if (validation.Succeeded) 
                await Repository.Save(entity);

            return (validation.Succeeded, validation.Errors);
        }
    }
}
