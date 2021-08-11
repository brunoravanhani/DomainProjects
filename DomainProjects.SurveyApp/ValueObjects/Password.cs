namespace DomainProjects.SurveyApp.ValueObjects
{
    public struct Password
    {
        private readonly string _password;

        public Password(string password)
        {
            _password = password;
        }

        public static implicit operator Password(string value) => new(value);

        public override string ToString() => _password;
    }
}
