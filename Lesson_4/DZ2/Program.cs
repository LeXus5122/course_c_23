Console.Write("Введите число, сумму цифр которых нужно посчитать: ");
int y = int.Parse(Console.ReadLine()!);
            int x = 0;
            while (y > 0)
            {
 
                x = x + y % 10;
                y = y /10 ;
 
            }
 Console.WriteLine(x);