namespace Nullability
{
    public class Person
    {

        private string? _firstName;
        private string? _lastName;

        public string FirstName
        {
            get { return _firstName!; }

            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);
                _firstName = value;
            }
        }
        public Person(string firstName, string lastName) { 

            FirstName = firstName;
            LastName = lastName;
        }

        public void SetName(string name)
        {

        }

        public string LastName
        {
            get { return _lastName!; }

            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);
                _lastName = value;
            }
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public (string FirstName, string LastName) GetNames()
        {
            var temp = GetNames().LastName = "Montoya";
            return (FirstName, LastName);
        }



    }
}