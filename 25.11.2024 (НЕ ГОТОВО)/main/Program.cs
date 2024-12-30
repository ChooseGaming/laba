using System;

class prog
{
    static void Main()
    {
        string txt = RL().ToLower();
        string prev = "0";
        int strike = 1, MaxStrike = 0;
        string MostPopular = "0";
        for (int i = 0; i < txt.Length; i++)
        {
            if (i==0)
            {
                prev = txt[i].ToString();
                MostPopular = txt[i].ToString();
            }
            else if (prev == txt[i].ToString())
            {
                strike += 1;
            } else
            {
                if (MaxStrike < strike)
                {
                    MaxStrike = strike;
                    MostPopular = txt[i].ToString();
                }
                prev = txt[i].ToString();
                strike = 1;
            }
        }
        Console.WriteLine($"Самый частый символ, учавствующий в комбинации a*b: {MostPopular} ({MaxStrike})");
        
    }

    static string RL()
    {
        Console.WriteLine("Введите строку");
        string txt = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(txt);
        return txt;
    }
}