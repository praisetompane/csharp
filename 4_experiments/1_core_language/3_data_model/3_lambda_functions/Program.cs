int fib(int n) =>
    n switch
    {
        int when n <= 2 => 1,
        _ => fib(n - 2) + fib(n - 1)
    };

Console.WriteLine(fib(10));