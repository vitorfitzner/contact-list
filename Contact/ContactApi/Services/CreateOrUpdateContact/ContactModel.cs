namespace ContactApi.UpdateContact
{
    public class ContactModel
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string PhoneNumber { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
    }
}
