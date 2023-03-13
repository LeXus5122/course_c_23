void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.WriteLine($"{arr[i]} ");
    Console.WriteLine();

}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int RetNum(int[] Mass, int from, int to)
{
    int count = 0;
    for (int i=0; i<Mass.Length; i++)
{
    if(Mass[i]>=from & Mass[i]<=to)
    count = count +1;
}
return count;
}





// void SumPosNeg(int[] arr)
// {
//     int pos, neg;
//     pos = neg = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//             pos += arr[i];
//         else
//             neg += arr[i];
//     }
//     Console.WriteLine($"Positive: {pos}, Negative: {neg}");
// }
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int first     = int.Parse(Console.ReadLine()!);
int second = int.Parse(Console.ReadLine()!);
int result = RetNum(mass, first, second);
Console.WriteLine(result);