using Xunit;
using NSubstitute;
using FluentAssertions;
using ContactApi.UpdateContact;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace ContactApiTest.UpdateContactTest
{

    public class ContactValidationTest
    {
        [Fact]
        public void ValidateSucceededTest()
        {
            Contact contact = new();
            contact.Id = Guid.NewGuid();
            contact.Name = "vitor";
            contact.Email = "vitor@teste.com";
            contact.PhoneNumber = "955668596";

            var validation = ContactValidation.Validate(contact);

            validation.Succeeded.Should().BeTrue();
            validation.Errors.Should().BeEmpty();
        }

        [Fact]
        public void ValidateNameTest()
        {
            Contact contact = new();

            var validation = ContactValidation.Validate(contact);

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("name can not be empty");
        }

        [Fact]
        public void ValidatePhoneNumberTest()
        {
            Contact contact = new();

            var validation = ContactValidation.Validate(contact);

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("phone number can not be empty");
        }

        [Fact]
        public void ValidateEmailTest()
        {
            Contact contact = new();

            var validation = ContactValidation.Validate(contact);

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("email can not be empty");
        }
    }
}
