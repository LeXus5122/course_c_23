Console.Write("Цифра 1 = 1, введите цифру 2: ");
        int m = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }