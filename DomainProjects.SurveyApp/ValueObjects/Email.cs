namespace DomainProjects.SurveyApp.ValueObjects
{
    public struct Email
    {
        private readonly string _address;

        public Email(string address)
        {
            _address = address;
        }

        public static implicit operator Email(string value) => new(value);

        public override string ToString() => _address;
    }
}
