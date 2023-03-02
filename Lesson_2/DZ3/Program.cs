// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int digit = 0;

// if (num > 99)
// {
//     digit = (num / 100) % 10;
// }
// else{
//     Console.WriteLine("В числе меньше трех цифр");
// }
// if (digit != 0)
// {
//     Console.WriteLine("Третья цифры в числе: " + digit);
// }

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 100 && number <= 999) 
{
    int num1 = number % 10;
    Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
} 

else if (number >= 1000 && number <= 9999) 
{
    int num1 = (number / 10) % 10;
    Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
} 

else if (number >= 10000 && number <= 99999) 
{
    int num1 = (number / 100) % 10;
    Console.WriteLine("Третья цифра числа " + number + " равна " + num1);
} 

else if (number > 99999) 
{
    Console.WriteLine("Некорректное число");
}

else if (number < 100) 
{
    Console.WriteLine("Нет третьей цифры");
}


