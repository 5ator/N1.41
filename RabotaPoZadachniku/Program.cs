using System;
class Programm
{
    static void Main()
    {
        double e, f, g, h, a, b, c;
        Console.WriteLine("Введите значение e");
        e = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значениe f");
        f = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение g");
        g = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение h");
        h = int.Parse(Console.ReadLine());
        a = Math.Sqrt((Math.Pow(Math.Abs(e - 3 / f), 3) + g));
        b = Math.Sin(e) + Math.Pow(Math.Cos(h), 2);
        c = (33 * g) / (e * f - 3);
        Console.WriteLine("a={0},b={1},c={2}", a, b, c);

    }
}


