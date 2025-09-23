int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c);

// simulate type overflow and catching it
long d = a + b;
Console.WriteLine($"Overflowed Integer {d}");
// One solution, but ideally one should know the domain of discourse and choose appropriate types
d = checked(a + b);

decimal bill = 59.99M;

Console.WriteLine($"Total: ${bill}");

double temperature = 31.89;
Console.WriteLine($"It is {temperature}ᴼC outside");