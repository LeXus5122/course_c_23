int m = 3;
int n = 4;

int[,] array = new int[3, 4]
    {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

double[] averages = new double[n];

for (int col = 0; col < n; col++)
{
    double sum = 0;
    for (int row = 0; row < m; row++)
    {
        sum += array[row, col];
    }
    averages[col] = sum / m;
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Столбец {i}: {averages[i]:F2}");
}