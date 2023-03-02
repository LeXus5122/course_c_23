// See https://aka.ms/new-console-template for more information

void Div(int num1, int num2)
{
    if (num1 % num2 == 0) Console.WriteLine("Кратно");
    else
    {
        Console.WriteLine("Не кратно " + num1 % num2);
    }
}

// int num3 = int.Parse(Console.ReadLine()!);
// int num4 = int.Parse(Console.ReadLine()!);
// int result = Div( num3, num4 );
// return result;

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Div(a, b);
