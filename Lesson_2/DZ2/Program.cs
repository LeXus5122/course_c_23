// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Генерируется число");
//int num = new Random().Next(10,99);
//int a = num / 10
//Console.WriteLine(a);

int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 100;
    int num2 = num % 10;
    int final = (num1*10) + num2;
    return final;
}

int result = TakeNum(new Random().Next(100, 999));
Console.WriteLine(result);
