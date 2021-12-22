using ContactApi.CreateContact;
using Xunit;

namespace ContactApiTest.CreateContactTest
{
    public class ContactValidationTest
    {
        [Fact]
        public void ValidateContactName()
        {
            var contact = new ContactDto();

            var (_, errors) = ContactValidation.Validate(contact);

            Assert.Contains("name can not be empty", errors);
        }

        [Fact]
        public void ValidateContactEmail()
        {
            var contact = new ContactDto();

            var (_, errors) = ContactValidation.Validate(contact);

            Assert.Contains("email can not be empty", errors);
        }

        [Fact]
        public void ValidateContactPhoneNumber()
        {
            var contact = new ContactDto();

            var (_, errors) = ContactValidation.Validate(contact);

            Assert.Contains("email can not be empty", errors);
        }
    }
}
