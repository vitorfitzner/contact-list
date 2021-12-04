using Xunit;
using NSubstitute;
using FluentAssertions;
using ContactApi.UpdateContact;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace ContactApiTest.UpdateContactTest
{
    public class ContactTest
    {
        
    }

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

    public class UpdateContactServiceTest
    {
        [Fact]
        public void T()
        {
            var repository = Substitute.For<IContactRepository>();

            UpdateContactService updateContactService = new UpdateContactService(repository);

        }
    }
}
