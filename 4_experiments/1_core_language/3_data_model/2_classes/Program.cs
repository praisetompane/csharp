using Home;

var p1 = new Person("Ben", "Mogale", new DateOnly(2000, 12, 1));
var p2 = new Person("Bob", "Phaahle", new DateOnly(2010, 4, 15));
var p3 = new Person("Philip", "Brown", new DateOnly(2010, 2, 2));
var p4 = new Person("Sakura", "Nakamoto", new DateOnly(2010, 1, 30));

p1.Pets.Add(new Dog("Bill"));
p1.Pets.Add(new Dog("Fred"));

p2.Pets.Add(new Cat("Jen"));

List<Person> people = [p1, p2, p3, p4];

foreach (var person in people)
{
    Console.WriteLine(person);
}