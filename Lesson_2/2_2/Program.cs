// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Генерируется число");
//int num = new Random().Next(10,99);
//int a = num / 10
//Console.WriteLine(a);

int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num % 10;
    if (num1 > num2) return num1;
    return num2;
}

int result = TakeNum(new Random().Next(10, 99));
Console.WriteLine(result);