using Xunit;
using NSubstitute;
using ContactApi.UpdateContact;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using static System.Array;

namespace ContactApiTest.TestUpdateContact
{
    public class TestContactController
    {
        readonly ContactController controller = new();

        [Fact]
        public async Task TestPutContactResponseEntityErrors()
        {
            ////given
            //var contact = new ContactModel();

            //var contactService = Substitute.For<ContactService>(null);

            //contactService.CreateOrUpdate(Arg.Any<ContactModel>()).Returns((succeeded: true, errors: Empty<string>()));

            ////when
            //var response = await controller.Put(new ContactModel(), contactService);

            ////then
            //response.Should().BeOfType<NoContentResult>();
        }

        [Fact]
        public async Task TestPutContactWithErrorsResponseBadRequest()
        {
            //var contact = new ContactDto();

            //var updateContactService = Substitute.For<IUpdateContactService>();
            //updateContactService.Update(contact).Returns((false, ));


            //var response = await controller.Put(contact, updateContactService);

            //response.Should().BeOfType<BadRequestObjectResult>();
        }
    }
}
