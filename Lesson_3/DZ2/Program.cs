// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $   
// и округлить числа

double dis(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Введите поочередно значения x1, y1, z1, x2, y2, z2: ");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(dis(x1, y1, z1, x2, y2, z2)) + " (Значение округлено)");