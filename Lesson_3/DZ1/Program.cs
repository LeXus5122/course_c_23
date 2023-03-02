Console.Write("Введите пятизначное числочисло: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10000 && number <= 99999)
{
    int num1 = (number / 10000);
    int num2 = (number / 1000 % 10);
    int num4 = (number / 10 % 10);
    int num5 = (number % 10);
     if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Да");
}
     else
     {
        Console.WriteLine("Нет");
     }
}
 
else
{
    Console.WriteLine("Это не пятизначное число");
}