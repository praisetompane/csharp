using Home;

namespace Home
{
    public class Cat(string firstname) : Pet(firstname)
    {
        public override string Speak() => "Meow";
    }
}