namespace ContactApi.UpdateContact
{
    public class ValidationResult
    {
        public bool Succeeded => errors.Count == 0;
        public string[] Errors => errors.ToArray(); 

        private List<string> errors = new List<string>();

        public void AddError(string error)
        {
            errors.Add(error);
        }
    }
}
