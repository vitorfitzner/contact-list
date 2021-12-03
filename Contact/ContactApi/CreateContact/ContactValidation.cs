namespace ContactApi.CreateContact
{
    public static class ContactValidation
    {
        public static (bool isValid, string[] errors) Validate(this ContactDto contact)
        {
            var errors = new List<string>();

            if (contact.Name == "")
                errors.Add("name can not be empty");

            if (contact.Email == "")
                errors.Add("email can not be empty");

            if (contact.PhoneNumber == "")
                errors.Add("phone number can not be empty");

            return (errors.Count == 0, errors.ToArray());
        }
    }
}