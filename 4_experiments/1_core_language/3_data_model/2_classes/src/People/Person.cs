using Home;

namespace Home
{
    public class Person(string firstname, string lastname, DateOnly birthdate)
    {
        public string FirstName { get; } = firstname;

        public string LastName { get; } = lastname;

        public DateOnly BirthDate { get; } = birthdate;

        public List<Pet> Pets = new();

        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthDate}. Pets: {(Pets.Count() > 0 ? string.Join(", ", Pets) : "None")}";
        }
    }
}