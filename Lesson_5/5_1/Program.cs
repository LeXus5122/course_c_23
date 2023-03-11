int[] InputRandomMassive(int lenghtMas, int minRangeMas, int maxRangeMas)
{
    int[] masRandom = new int[lenghtMas];
    for (int i = 0; i < lenghtMas; i++)
    {
        masRandom[i] = new Random().Next(minRangeMas, maxRangeMas);
    }
    return masRandom;
}

void PrintMassive(int[] mas)
{
    for (int i = 0; i<mas.Length; i++)
        Console.Write($" {mas[i]} ");
    Console.WriteLine();
}

void MassConverter(int[] arry)
{
    for (int i=0; i<arry.Length; i++)
    arry[i]=-arry[i];
}

Console.WriteLine("Введите длину массива:");
int lenghtMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапазона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапазона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassive(lenghtMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);
MassConverter(masRandom);
PrintMassive(masRandom);