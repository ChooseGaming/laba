using System;

class prog
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Начальные a = {a} | b = {b}");
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine($"Конечные a = {a} | b = {b}");
        Console.WriteLine($"В порядке возрастания: {(a + b - Math.Abs(a - b))/2}, {(a + b + Math.Abs(a - b)) / 2}");
    }
}