int m = 3;
int n = 4;

int[,] array = new int[3, 4]
    {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};


Console.Write("Введите номер строки (от 0 до {0}): ", m - 1);
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца (от 0 до {0}): ", n - 1);
int col = int.Parse(Console.ReadLine()!);

if (row >= 0 && row < m && col >= 0 && col < n)
{
    Console.WriteLine($"Значение элемента при m {row} и n {col}: {array[row, col]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет.");
}
