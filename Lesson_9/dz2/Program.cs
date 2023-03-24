void Main(string[] args)
{
    int M = 1;
    int N = 5;
    int sum = 0;
    Spacing(M, N, ref sum);
    Console.WriteLine($"\nСумма чисел от {M} до {N}: {sum}");
}
void Spacing(int M, int N, ref int sum)
{
    if (N < M) return;
    Spacing(M, N - 1, ref sum);
    Console.Write($"{N}, ");
    sum += N;
}

Main(args);