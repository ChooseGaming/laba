using System;

class prog
{
    static void Main()
    {
        int[,] arr = FormArray();
        Print(arr);
        int MinI = 0, MaxI = 0, MinJ = 0, MaxJ = 0, Minimax = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == 0 && j == 0)
                {
                    MinI = MaxI = i;
                    MinJ = MaxJ = arr[i, j];
                }
                else
                {
                    if (MinJ > arr[i, j])
                    {
                        MinJ = arr[i, j];
                        MinI = i;
                    }
                    if (MaxJ < arr[i, j])
                    {
                        MaxJ = arr[i, j];
                        MaxI = i;
                    }
                }
            }
            if (i == 0) Minimax = MinJ;
            else if (Minimax < MinJ) Minimax = MinJ;
        }
        SwitchArr(ref arr, MaxI, MinI);
        Print(arr);
        Console.WriteLine($"Минимакс: {Minimax}");
        Console.WriteLine("Пары строк:");
        for (int i = 0; i < arr.GetLength(0)-1; i++)
        {
            for (int j = i + 1; j < arr.GetLength(0); j++)
            {
                bool isNum = false;
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    isNum = false;
                    for (int l = 0; l < arr.GetLength(1); l++)
                    {
                        if (arr[i,k] == arr[j,l]) isNum = true;
                    }
                    if (!isNum) break;
                }
                if (isNum)
                {
                    Console.WriteLine($"{i + 1} {j + 1}");
                    break;
                }
            }
        }
        Console.WriteLine();
    }

    static void SwitchArr(ref int[,] arr, int fLine, int sLine)
    {
        int[] buf = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            buf[i] = arr[fLine, i];
            arr[fLine, i] = arr[sLine, i];
            arr[sLine, i] = buf[i];
        }
    }

    static int[,] FormArray()
    {
        Console.WriteLine("Введите количество строк");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество элементов в каждой строке");
        int hmany = int.Parse(Console.ReadLine());
        int[,] arr = new int[count, hmany];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"Введите {j + 1} элемент {i + 1} строки");
                arr[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        return arr;
    }

    static void Print(int[,] arr)
    {
        Console.WriteLine("");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j] + " | ");
            }
        }
        Console.WriteLine();
    }
}