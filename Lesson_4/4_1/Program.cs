// Напишите программу, которая принимает 
// на вход исло и выдает колличество цифр в числе.

int LenghNum (int num)
{
    int a=0;
    for(int i=1; num>0; i++)
        {num=num/10;
        a++;
        }
    return a;    
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = LenghNum(num);
Console.WriteLine(result);