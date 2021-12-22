using Xunit;
using FluentAssertions;
using ContactApi.UpdateContact;
using ContactApi.Services.ContactAggregate;

namespace ContactApiTest.TestUpdateContact
{
    public class TestContact
    {
        [Fact]
        public void TestNewContactHasDefaultValues()
        {
            var contact = new Contact();

            contact.ContactId.Should().BeEmpty();
            contact.Name.Should().BeEmpty();
            contact.Email.Should().BeEmpty();
            contact.PhoneNumber.Should().BeEmpty();
        }
    }
}
