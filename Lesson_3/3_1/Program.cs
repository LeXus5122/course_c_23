﻿// See https://aka.ms/new-console-template for more information
void Quarters(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (num == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("not chetvert'");
}
Console.WriteLine("Введите 4etvert");
int num = int.Parse(Console.ReadLine()!);
Quarters(num);