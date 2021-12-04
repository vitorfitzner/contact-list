namespace ContactApi.UpdateContact
{
    public interface IContactRepository
    {
        Task Save(Contact contact);
    }
}
