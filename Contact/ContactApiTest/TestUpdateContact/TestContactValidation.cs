using Xunit;
using FluentAssertions;
using ContactApi.UpdateContact;
using System;
using ContactApi.Services.CreateOrUpdateContact;

namespace ContactApiTest.TestUpdateContact
{
    public class TestContactValidation
    {
        [Fact]
        public void TestValidateSucceeded()
        {
            var contact = new Contact
            {
                ContactId = Guid.NewGuid(),
                Name = "vitor",
                Email = "vitor@teste.com",
                PhoneNumber = "955668596"
            };

            var validation = contact.Validate();

            validation.Succeeded.Should().BeTrue();
            validation.Errors.Should().BeEmpty();
        }

        [Fact]
        public void TestValidateName()
        {
            Contact contact = new();

            var validation = contact.Validate();

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("name can not be empty");
        }

        [Fact]
        public void TestValidatePhoneNumber()
        {
            Contact contact = new();

            var validation = contact.Validate();

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("phone number can not be empty");
        }

        [Fact]
        public void TestValidateEmail()
        {
            Contact contact = new();

            var validation = contact.Validate();

            validation.Succeeded.Should().BeFalse();
            validation.Errors.Should().Contain("email can not be empty");
        }
    }
}
