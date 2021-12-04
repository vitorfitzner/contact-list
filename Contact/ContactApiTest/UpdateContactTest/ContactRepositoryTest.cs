using Xunit;
using ContactApi.UpdateContact;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactApiTest.UpdateContactTest
{
    public class ContactRepositoryTest
    {
        [Fact]
        public async Task SaveTest()
        {
            var options =new DbContextOptionsBuilder<ContactRepository>()
                .UseInMemoryDatabase("test")
                .Options;

            var contact = new Contact();

            IContactRepository sut = new ContactRepository(options);

            await sut.Save(contact);
        }
    }
}
