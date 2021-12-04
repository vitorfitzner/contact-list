using Xunit;
using NSubstitute;
using ContactApi.UpdateContact;
using System.Threading.Tasks;

namespace ContactApiTest.UpdateContactTest
{
    public class ContactControllerTest
    {
        [Fact]
        public async Task PutContactSucceededTest()
        {
            var contact = new ContactDto();

            var updateContactService = Substitute.For<IUpdateContactService>();

            ContactController controller = new ();

            await controller.Put(contact, updateContactService);
        }

        [Fact]
        public async Task PutContactFailureTest()
        {
            var contact = new ContactDto();

            var updateContactService = Substitute.For<IUpdateContactService>();

            ContactController controller = new();

            await controller.Put(contact, updateContactService);
        }
    }
}
