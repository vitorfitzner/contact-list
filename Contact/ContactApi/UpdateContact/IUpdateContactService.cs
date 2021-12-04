namespace ContactApi.UpdateContact
{
    public interface IUpdateContactService
    {
        Task<(bool updateSucceeded, string[] errors)> Update(ContactDto contact);
    }
}
