using Microsoft.AspNetCore.Mvc;

namespace ContactApi.UpdateContact
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpPut(Name = "create-or-update-contact")]
        public async Task<ActionResult> Put([FromBody] ContactModel contact, [FromServices] ContactService service)
        {
            var (errors, newContactCreated) = await service.CreateOrUpdate(contact);

            if (errors.Any()) 
                return UnprocessableEntity(errors);

            if (newContactCreated)
                return Created("", contact);

            return Ok(contact);
        }
    }
}
