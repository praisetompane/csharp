Console.WriteLine("Array Construction and Iteration:");

var fruits = new string[] { "Pear", "Orange", "Banana", "Tangarine" };

Console.WriteLine("Array Iteration");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Adding to an Array");
fruits = [.. fruits, "Apple"];


Console.WriteLine(string.Join(", ", fruits));

Console.WriteLine("Array Slicing");

Console.WriteLine($"Last element {fruits[^1]}");

Console.WriteLine("Fruits 3 to 4");
foreach (var fruit in fruits[2..4])
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Array In Place Sorting");
fruits.Sort();