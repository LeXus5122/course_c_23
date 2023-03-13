        Console.Write("Введите количество генерируемых чисел: ");
        int count = int.Parse(Console.ReadLine()!);

        int[] arr = new int[count];
        for (int i = 0; i < count; i++) {
            arr[i] = new Random().Next(100, 1000);
        }

        int numCount = 0;
        Console.Write("Сгенерированный массив: ");
        foreach (int num in arr) {
            Console.Write($"{num} ");
            if (num % 2 == 0) {
                numCount++;
            }
        }

        Console.WriteLine($"Колличество четных чисел в массиве: {numCount}");