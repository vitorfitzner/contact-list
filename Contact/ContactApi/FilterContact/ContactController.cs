using Microsoft.AspNetCore.Mvc;

namespace ContactApi.FilterContact
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController : ControllerBase
    {
        [HttpGet("{id:guid}", Name = "filterbyid")]
        public async Task<ActionResult> Get([FromRoute] Guid id)
        {
            //var contact = await service.FilterContactBy(id);

            //if (contact == null)
            //    return NotFound();

            //return Ok(contact);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //var contact = await service.FilterContactBy(id);
            //
            return Ok();
        }
    }

    public interface IFilterContactService
    {
        Task<ContactDto> FilterContactBy(Guid id);
    }

    public class FilterContactService : IFilterContactService
    {
        public Task<ContactDto> FilterContactBy(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    public class ContactDto
    {

    }
}
