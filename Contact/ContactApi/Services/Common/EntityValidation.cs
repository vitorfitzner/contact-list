namespace ContactApi.Common
{
    public class EntityValidation
    {
        public bool Succeeded => _errors.Count == 0;
        public string[] Errors => _errors.ToArray();

        private readonly List<string> _errors = new();

        public void AddError(string error)
        {
            _errors.Add(error);
        }
    }
}
