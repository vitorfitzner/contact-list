namespace ContactApi.CreateContact
{
    public class ContactCreated
    {
        public ContactCreated(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }
    }
}
