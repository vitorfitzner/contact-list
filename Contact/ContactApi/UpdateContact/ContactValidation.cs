namespace ContactApi.UpdateContact
{
    public static class ContactValidation
    {
        public static ValidationResult Validate(this Contact contact)
        {
            ValidationResult result = new();

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
