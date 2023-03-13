Console.Write("Введите количество вещественных чисел: ");
int count = int.Parse(Console.ReadLine()!);

int[] arr = new int[count];
for (int i = 0; i < count; i++)
{
    arr[i] = new Random().Next(1, 99);
    Console.WriteLine(arr[i]);
}

int max = arr[0];
int min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

int razn = max - min;

Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {razn}");