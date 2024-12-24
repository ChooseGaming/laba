using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int prev = 0, strike = 1, MaxStrike = 1, summ = 0, MaxSumm = 0;
        int? MinStrike = null;
        for (int i = 0; i < count; i++)
        {

            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                summ += num;
            } else
            {
                summ = 0;
            }
            MaxSumm = MaxSumm < summ ? summ : MaxSumm;
            if (i == 0)
            {
                prev = num;
                continue;
            }

            if (prev == num)
                strike++;
            else
            {
                if (prev == 0)
                {
                    if (MinStrike == null) MinStrike = strike;
                    else MinStrike = MinStrike < strike ? MinStrike : strike;
                }
                MaxStrike = MaxStrike < strike ? strike : MaxStrike;
                prev = num;
                strike = 1;
            }
        }
        if (prev == 0)
        {
            Console.WriteLine($"STRIKE: {strike}");
            if (MinStrike == null) MinStrike = strike;
            else MinStrike = MinStrike < strike ? MinStrike : strike;
        }
        MaxStrike = MaxStrike < strike ? strike : MaxStrike;
        Console.WriteLine($"Максимальная подпоследовательность из одинаковых элементов: {MaxStrike} | Минимальная из нулей: {MinStrike} | Максимальная сумма из чётных: {MaxSumm}");
    }
}