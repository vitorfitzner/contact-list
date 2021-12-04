using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.DeleteContact
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete([FromRoute]Guid id, [FromServices] IDeleteContactService service)
        { 
            await service.Delete(id);

            return NoContent();
        }
    }

    public interface IDeleteContactService
    {
        Task Delete(Guid id);
    }

    public class DeleteContactService : IDeleteContactService
    {
        public DeleteContactService(IContactRepository contactRepository)
        {
            ContactRepository = contactRepository;
        }

        public IContactRepository ContactRepository { get; }

        public async Task Delete(Guid id)
        {
            await ContactRepository.Delete(id);
        }
    }

    public interface IContactRepository
    {
        Task Delete(Guid id);
    }

    public class ContactRepository : DbContext, IContactRepository
    {
        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
