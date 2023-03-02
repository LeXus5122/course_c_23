Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day == 6 | day == 7) 
{
    Console.WriteLine("Это выходной день!");
} 
else 
{
    Console.WriteLine("Это рабочий день.");
}