namespace ContactApi.CreateContact
{
    public interface ICreateContactService
    {
        Task<(string[] errors, Guid contactId)> Create(ContactDto contact);
    }
}