using System;

class prog
{
    static void Main()
    {
        string txt = RL().ToLower();
        string symbols = "";
        string hmuch = "";
        int strike = 0, MaxStrike = 0;
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == 'a')
            {
                strike++;
                i++;
                if (i < txt.Length && txt[i] == 'b')
                {
                    strike++;
                    i++;
                    if (i < txt.Length && txt[i] == 'c')
                    {
                        strike++;
                    }
                    else
                    {
                        MaxStrike = MaxStrike < strike ? strike : MaxStrike;
                        strike = 0;
                    }
                }
                else
                {
                    MaxStrike = MaxStrike < strike ? strike : MaxStrike;
                    strike = 0;
                }
            } 
            else
            {
                MaxStrike = MaxStrike < strike ? strike : MaxStrike;
                strike = 0;
            }
        }
        MaxStrike = MaxStrike < strike ? strike : MaxStrike;
        if (txt.Length >= 3) for (int i = 2; i < txt.Length; i++)
            {
                if (txt[i-2] == 'a' && txt[i] == 'b')
                {
                    if (!symbols.Contains(txt[i - 1].ToString())) symbols += $"{txt[i - 1]} ";
                    hmuch += txt[i - 1];
                }
            }
        string[] listOfS = symbols.Split(' ');
        int Max = 0;
        char S = ' ';
        for (int i = 0; i < listOfS.Length-1; i++)
        {
            if (i == 0)
            {
                Max = hmuch.Split(listOfS[i][0]).Length - 1;
                S = listOfS[i][0];
                continue;
            }
            if (Max < hmuch.Split(listOfS[i][0]).Length - 1)
            {
                Max = hmuch.Split(listOfS[i][0]).Length - 1;
                S = listOfS[i][0];
            }
        }
        Console.WriteLine($"Наиболее часто встречаемый символ: \"{S}\" ({Max})");
        Console.WriteLine($"Наибольшее количество подряд идущих abc: {MaxStrike}");
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


//На вход подается строка. Необходимо определить  символ, который чаще всего
//встречается в комбинации a*b. Регистр не учитывается.

//На вход подается строка. Определить максимальную длину подпоследовательности,
//состоящей из троек элементов abc. 

