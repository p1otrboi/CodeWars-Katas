while (true)
{
    Dictionary<int, long> dict = new Dictionary<int, long>();
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(Fib(n, dict).ToString());
}

long Fib(int n, Dictionary<int, long> dict)
{
    if (dict.TryGetValue(n, out long value))
        return value;
    if (n <= 2)
        return 1;
    else
    {
        dict[n] = Fib(n - 1, dict) + Fib(n - 2, dict);
        return dict[n];
    }
}
