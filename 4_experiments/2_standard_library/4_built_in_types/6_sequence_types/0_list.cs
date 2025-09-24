Console.WriteLine("List Construction and Iteration:");

var fruits = new List<string> { "Pear", "Orange", "Banana", "Tangarine" };

Console.WriteLine("List Iteration");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Adding to a List");
fruits.Add("Apple");

Console.WriteLine(string.Join(", ", fruits));

Console.WriteLine("List Slicing");

Console.WriteLine($"Last element {fruits[^1]}");

Console.WriteLine("Fruits 3 to 4");
foreach (var fruit in fruits[2..4])
{
    Console.WriteLine(fruit);
}

Console.WriteLine("List Inplace Sorting");
fruits.Sort();
Console.WriteLine(string.Join(", ", fruits));