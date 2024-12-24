using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int max = 0, Premax = 0, NegCount = 0, min = 0, Premin = 0;
        for (int i = 0; i < count; i ++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0) NegCount++;
            if (i == 0)
            {
                min = num;
                max = num;
            } else
            {
                if (num > max)
                {
                    Premax = max;
                    max = num;
                }

                if (num < min)
                {
                    Premin = min;
                    min = num;
                }


            }
        }
        Console.WriteLine($"Количество отрицательных элементов: {NegCount} | Второй максимальный элемент: {Premax} | Локальные минимумы: {min}, {Premin}");
    }
}
