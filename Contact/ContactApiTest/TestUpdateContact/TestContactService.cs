using static System.Guid;
using System.Threading.Tasks;
using ContactApi.UpdateContact;
using Xunit;
using NSubstitute;
using FluentAssertions;

namespace ContactApiTest.TestUpdateContact
{
    public class TestContactService
    {
        [Fact]
        public async Task TestCreateNewContact()
        {
            //setup
            var repository = Substitute.For<ContactRepository>();
            var contactService = new ContactService(repository);

            //given
            var contact = new ContactModel
            {
                Id = NewGuid(),
                Name = "vitor",
                Email = "vitor@teste.com",
                PhoneNumber = "12394u1234"
            };

            //when
            var (errors, newContactCreated) = await contactService.CreateOrUpdate(contact);

            //then
            errors.Should().BeEmpty();
            newContactCreated.Should().BeTrue();
        }

        [Fact]
        public async Task TestUpdateContact()
        {
            //setup
            var repository = Substitute.For<ContactRepository>();
            var contactService = new ContactService(repository);

            //given
            var contact = new ContactModel
            {
                Id = NewGuid(),
                Name = "vitor",
                Email = "vitor@teste.com",
                PhoneNumber = "12394u1234"
            };

            //when
            await contactService.CreateOrUpdate(contact);

            var (errors, newContactCreated) = await contactService.CreateOrUpdate(contact);

            //then
            errors.Should().BeEmpty();
            newContactCreated.Should().BeFalse();
        }
    }
}
