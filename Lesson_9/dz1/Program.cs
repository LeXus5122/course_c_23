
int M = 1;
int N = 5;
PrintEvenNumbers(M, N);
Console.WriteLine();

M = 4;
N = 8;
PrintEvenNumbers(M, N);
Console.WriteLine();

void PrintEvenNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }

    if (M % 2 == 0)
    {
        Console.Write(M);

        if (M + 1 <= N)
        {
            Console.Write(", ");
        }
    }

    PrintEvenNumbers(M + 1, N);
}
