using Home;

namespace Home
{
    public class Dog(string firstname) : Pet(firstname)
    {
        public override string Speak() => "Bark";
    }
}