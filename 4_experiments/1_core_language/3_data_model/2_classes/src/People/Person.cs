namespace People
{
    public class Person(string firstname, string lastname, DateOnly birthdate)
    {
        public string FirstName { get; } = firstname;

        public string LastName { get; } = lastname;

        public DateOnly BirthDate { get; } = birthdate;
    }
}