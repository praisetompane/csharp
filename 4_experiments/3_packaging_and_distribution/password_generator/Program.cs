using PasswordGenerator;

Console.WriteLine("Please provide me a name");
var name = Console.ReadLine();

var passwordGenerator = new Password();
var password = passwordGenerator.Next();

Console.WriteLine($"Greeting {name}. Your new password is {password}");
