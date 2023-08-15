Console.Write("Enter the first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(a, b);
    int min = Math.Min(a, b);
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");