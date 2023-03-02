// See https://aka.ms/new-console-template for more information

void Div(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 & num1 % num3 == 0 ) Console.WriteLine("Кратно");
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
int b = 7;
int c = 23;

Div(a, b, c);
