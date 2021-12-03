using Microsoft.AspNetCore.Mvc;

namespace ContactApi.CreateContact
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController : ControllerBase
    {
        //[HttpPost]
        //public async Task<ActionResult> Post(ContactDto contact, [FromServices] ICreateContactService service)
        //{
        //    var (errors, contactId) = await service.Create(contact);

        //    if (errors.Any())
        //        return BadRequest(errors);

        //    return CreatedAtAction("filterbyid", "contacts", contactId, contact);
        //}

        [HttpPost]
        public async Task<ActionResult> Post(ContactDto contact, [FromServices] ICreateContactService service)
        {
            var (errors, contactId) = await service.Create(contact);

            if (errors.Any())
                return BadRequest(errors);

            return Created($"/api/contacts/{contactId}", contact);
        }
    }
}