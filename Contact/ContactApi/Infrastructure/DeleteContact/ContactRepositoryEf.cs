namespace ContactApi.Infrastructure.DeleteContact
{
    public class ContactRepositoryEf : Services.DeleteContact.ContactRepository
    {
        public ContactRepositoryEf(ContactDataBase dataBase)
        {
            DataBase = dataBase;
        }

        public ContactDataBase DataBase { get; }

        public override async Task Delete(Guid id)
        {
            var entity = new { Id = id };
            //DataBase.ContactTable.Remove(entity);
            await DataBase.SaveChangesAsync();
        }
    }
}
