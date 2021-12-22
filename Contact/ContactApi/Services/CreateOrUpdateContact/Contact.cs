using ContactApi.Common;

namespace ContactApi.Services.CreateOrUpdateContact
{
    public class Contact : Entity
    {
        public Guid ContactId { get; init; }
        public string Name { get; init; } = string.Empty;
        public string PhoneNumber { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;

        public static Contact Empty => new();
    }
}
