Console.Write("Enter the first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(a, Math.Max(b, c));
Console.WriteLine($"Max: {max}");