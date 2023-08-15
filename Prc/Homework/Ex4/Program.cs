Console.Write("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even numbers from 1 to {0}:", N);

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }