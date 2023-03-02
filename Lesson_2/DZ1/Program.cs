// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Введите число");
//int x = int.Parse(Console.ReadLine()!);
//num = x % 10
//Console.WriteLine(num);

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10;
}
int Text = int.Parse(Console.ReadLine()!);
int result = TakeNum(Text);
Console.WriteLine(result);

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//Console.WriteLine(num % 10);