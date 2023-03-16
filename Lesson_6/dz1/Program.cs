Console.Write("Введите количество чисел: ");
    int m = int.Parse(Console.ReadLine()!);

    int count = 0;
    for (int i = 1; i <= m; i++)
    {
    Console.Write($"Введите число {i}: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
    }

Console.WriteLine($"Количество чисел, больших 0: {count}");