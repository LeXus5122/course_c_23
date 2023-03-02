// See https://aka.ms/new-console-template for more information

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number >= 100 && number <= 999) 
// {
//     int num1 = number % 10;
//     Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
// } 

// else if (number >= 1000 && number <= 9999) 
// {
//     int num1 = (number / 10) % 10;
//     Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
// } 

// else if (number >= 10000 && number <= 99999) 
// {
//     int num1 = (number / 100) % 10;
//     Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
// } 

// else if (number > 99999) 
// {
//     Console.WriteLine("Некорректное число");
// }

// else if (number < 100) 
// {
//     Console.WriteLine("Нет третьей цифры");
// }


void ThirdNum(int num)
{
    Console.Write($" {num} -> ");
    if (num < 100)
    {
        Console.WriteLine("there is no third digit");
    return;
    }

while (num > 999) num /= 10;
Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()!));