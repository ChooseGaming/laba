using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов в массиве");
        int count = int.Parse(Console.ReadLine()), count3 = 0, count2 = 0, sum2 = 0;
        int[] arr = new int[count];
        bool booler = true;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Введите {i+1} элемент массива");
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count2++;
                sum2 += arr[i];
            }
            if (arr[i] % 10 == 3) count3++;
            int num = arr[i], sum = 0;
            while (Math.Abs(num) >= 1)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine($"Сумма цифр {i + 1} элемента равна {sum}");
            if (i == 0) continue;
            if (arr[i - 1] > arr[i]) booler = false;
        }
        if (booler) Console.Write("Всё по возрастанию | ");
        else Console.Write("Не по возрастанию | ");
        Console.Write($"Количество чисел оканчивающихся на 3: {count3} | Среднеарифметическое чётных: {sum2 / count2} \n");
    }
}