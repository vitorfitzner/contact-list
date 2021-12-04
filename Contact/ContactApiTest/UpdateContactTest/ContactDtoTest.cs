using Xunit;
using FluentAssertions;
using ContactApi.UpdateContact;

namespace ContactApiTest.UpdateContactTest
{
    public class ContactDtoTest
    {
        [Fact]
        public void ContactDtoDefaultValuesTest()
        {
            var newContact = new ContactDto();

            newContact.Id.Should().BeEmpty();
            newContact.Name.Should().BeEmpty();
            newContact.Email.Should().BeEmpty();
            newContact.PhoneNumber.Should().BeEmpty();
        }
    }
}
