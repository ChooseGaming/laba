using System;

class ppp
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };
        Console.WriteLine(arr1.GetHashCode());
        Console.WriteLine(arr2.GetHashCode());
    }
}
