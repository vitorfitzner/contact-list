using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

////https://orkhanscience.medium.com/software-architecture-patterns-5-mins-read-e9e3c8eb47d2

namespace ContactApi.Services.DeleteContact
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id, [FromServices] DeleteContactService service)
        {
            await service.Delete(id);

            return NoContent();
        }
    }
}
