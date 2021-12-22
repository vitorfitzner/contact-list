////https://orkhanscience.medium.com/software-architecture-patterns-5-mins-read-e9e3c8eb47d2

namespace ContactApi.Services.DeleteContact
{
    public class DeleteContactService
    {
        public DeleteContactService(ContactRepository contactRepository)
        {
            ContactRepository = contactRepository;
        }

        public ContactRepository ContactRepository { get; }

        public async Task Delete(Guid id)
        {
            await ContactRepository.Delete(id);
        }
    }
}
