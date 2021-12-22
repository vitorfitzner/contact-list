using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.FilterContact
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController : ControllerBase
    {
        [HttpGet("{id:guid}", Name = "filter-contact-by-id")]
        public async Task<ActionResult> Get([FromRoute] Guid id, [FromServices]IFilterContactService service)
        {
            var (found, contact) = await service.FindContactBy(id);

            if (!found)
                return NotFound();

            return Ok(contact);
        }

        [HttpGet(Name = "filter-contact")]
        public async Task<ActionResult> Get([FromServices] IFilterContactService service)
        {
            return Ok();
        }
    }

    public interface IFilterContactService
    {
        Task<(bool found, ContactDto contact)> FindContactBy(Guid id);
    }

    public class FilterContactService : IFilterContactService
    {
        public FilterContactService(IContactRepository contactRepository)
        {
            ContactRepository = contactRepository;
        }

        public IContactRepository ContactRepository { get; }

        public async Task<(bool found, ContactDto contact)> FindContactBy(Guid id)
        {
            var entity = await ContactRepository.FindBy(id);

            var found = entity != null;

            var contact = new ContactDto();

            return (found, contact);
        }
    }

    public interface IContactRepository
    {
        Task<Contact> FindBy(Guid id);
    }

    public class Contact
    {
        public string Name { get; set; } = string.Empty;
    }

    public class ContactRepository : DbContext, IContactRepository
    {
        public ContactRepository(DbContextOptions opt) : base(opt)
        {

        }

        DbSet<Contact>? Contacts { get; set; }

        public async Task<Contact> FindBy(Guid id)
        {
            var entity = await Contacts.FindAsync(id);

            return entity;
        }
    }

    public class ContactDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
