using ContactApi.Common;
using ContactApi.Services.CreateOrUpdateContact;

namespace ContactApi.UpdateContact
{
    public static class ContactValidation
    {
        public static EntityValidation Validate(this Contact contact)
        {
            EntityValidation result = new();

            if (contact.Name == "")
                result.AddError("name can not be empty");

            if (contact.Email == "")
                result.AddError("email can not be empty");

            if (contact.PhoneNumber == "")
                result.AddError("phone number can not be empty");

            return result;
        }
    }
}
