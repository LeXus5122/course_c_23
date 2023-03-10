Console.Write("Введите число массив с которым необходимо создать: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите начала рандомного диапазона: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец рандомного диапазона: ");
int z = int.Parse(Console.ReadLine()!);

void FillArray(int[] collection)

{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(y, z);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}


int[] array = new int[x];

FillArray(array);
PrintArray(array);
