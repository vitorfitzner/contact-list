using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.UpdateContact
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ContactDto contact, [FromServices] IUpdateContactService service)
        {
            var (updateSucceeded, errors) = await service.Update(contact);

            if (updateSucceeded) return NoContent();

            return BadRequest(errors);
        }
    }
}
