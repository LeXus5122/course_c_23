Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = 0;

if (a > b &  a > c)
{
max = a;
}

else if (b > c & b > a)
{
   max = b;
}

else if (c > a & c > b)
{
   max = c;
}

Console.WriteLine(max);