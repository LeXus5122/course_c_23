﻿// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


void ExiTri(int n_1, int n_2, int n_3)
{
    if (n_1 < n_2 + n_3 && n_2 < n_1 + n_3 && n_3 < n_2 + n_1)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

// 1 2 3, 4 2 5
int num_1 = int.Parse(Console.ReadLine()!); 
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);  
ExiTri(num_1, num_2, num_3);
