Console.Write("Введите размер m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m, n];

Random random = new Random();

for (int i = 0; i < m; i++)
        {
        for (int j = 0; j < n; j++)
        {
        array[i, j] = random.NextDouble();
        }
        }

Console.WriteLine("Сгенерированный массив:");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Console.Write($"{array[i, j]:F1} ");
        }
        Console.WriteLine();
    }