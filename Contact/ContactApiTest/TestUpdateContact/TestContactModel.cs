using Xunit;
using FluentAssertions;
using ContactApi.UpdateContact;

namespace ContactApiTest.TestUpdateContact
{
    public class TestContactModel
    {
        [Fact]
        public void TestNewContactModelHasDefaultValues()
        {
            var newContact = new ContactModel();

            newContact.Id.Should().BeEmpty();
            newContact.Name.Should().BeEmpty();
            newContact.Email.Should().BeEmpty();
            newContact.PhoneNumber.Should().BeEmpty();
        }
    }
}
