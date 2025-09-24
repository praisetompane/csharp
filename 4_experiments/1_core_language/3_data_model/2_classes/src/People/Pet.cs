namespace Home
{
    public abstract class Pet(string firstname)
    {
        public string FirstName { get; } = firstname;

        public abstract string Speak();

        public override string ToString() => FirstName;
    }
}