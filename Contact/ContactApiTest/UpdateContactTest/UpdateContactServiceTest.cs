using Xunit;
using NSubstitute;
using ContactApi.UpdateContact;

namespace ContactApiTest.UpdateContactTest
{
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
