using ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController : ControllerBase
    {
        private static readonly List<Contact> _contacts = new();

        [HttpPost]
        public ActionResult Post([FromBody]Contact contact)
        {
            _contacts.Add(contact);

            return Ok();
        }

        [HttpGet]
        public ActionResult Put([FromBody]Contact contact)
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}