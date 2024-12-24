﻿using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк");
        int[][] arr = new int[int.Parse(Console.ReadLine())][];
        for (int i = 0; i < arr.Length; i++) { Console.WriteLine($"Введите количество элементов в {i+1} строке"); arr[i] = FullCell(int.Parse(Console.ReadLine())); }
        Visuality(arr);
        UbLogi(arr);
    }

    static void Visuality(int[][] arr)
    {
        Console.WriteLine("Ваш массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine();
            Console.Write("|");
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write($"{arr[i][j]}|");
            }
        }
        Console.WriteLine();
    }

    static int[] FullCell(int count)
    {
        int[] arr = new int[count];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < count; i++) arr[i] = int.Parse(Console.ReadLine());
        return arr;
    }

    static void UbLogi(int[][] arr)
    {
        Console.WriteLine();
        Console.Write("|");
        for (int i = 0; i < arr.Length; i++)
        {
            int b = 0;
            bool IsLog = true;
            for (int j = 0; j < arr[i].Length - 1; j++)
            {
                if (j == 0)
                {
                    if (arr[i][j] - arr[i][j + 1] > 0) b = arr[i][j] - arr[i][j + 1];
                    else IsLog = false;
                }
                else
                {
                    if (arr[i][j] - arr[i][j + 1] != b)
                    {
                        IsLog = false;
                        break;
                    }
                }
            }
            if (IsLog) Console.Write($"{i + 1}|");
        }
    }
}
