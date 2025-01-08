using System;

class poe
{
    static void Main()
    {
        int answer = 0;
        Console.WriteLine("Введите Станцию");
        Station st = new Station(Console.ReadLine());
        do
        {
            bool checker = false;
            PMenu();
            answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
            {
                Console.WriteLine("Введите номер поезда");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите время отправки в формате XX:YY");
                string time = Console.ReadLine();
                st.addTrain(new Train(st.name,num,time));
                Console.WriteLine("Поезд успешно добавлен");
            } else if (answer == 2)
            {
                Console.WriteLine("Введите время отправки в формате XX:YY");
                string[] timeStr = Console.ReadLine().Split(':');
                int[] time = { int.Parse(timeStr[0]), int.Parse(timeStr[1]) };
                for (int i = 0; i < st.trains.Length; i++)
                {
                    if (st.trains[i].time[0] == time[0])
                    {
                        if (st.trains[i].time[1] >= time[1])
                        {
                            Console.WriteLine(st.trains[i].B+ " - "+st.trains[i].number+ " - " + st.trains[i].timeStr);
                            checker = true;
                        }
                    } else if (st.trains[i].time[0] > time[0])
                    {
                        Console.WriteLine(st.trains[i].B + " - " + st.trains[i].number + " - " + st.trains[i].timeStr);
                        checker = true;
                    }
                }
                if (!checker)
                    Console.WriteLine("Соответствий не найдено");
            }

            Console.WriteLine();
        } while (answer != 3);
    }

    static void PMenu()
    {
        Console.WriteLine("1. Добавить поезд");
        Console.WriteLine("2. Список поездов, отправленных с момента");
        Console.WriteLine("3. Выход");
    }
}
class Train
{
    private string _B;
    public string B { get { return _B; } }
    private int _number;
    public int number { get { return _number; } }
    private string _time;
    public string timeStr { get { return _time; } }
    public int[] time
    {
        get
        {
            string[] timeStr = _time.Split(':');
            int[] tt = { int.Parse(timeStr[0]), int.Parse(timeStr[1]) };
            return tt;
        }
    }

    public Train(string B, int num, string time)
    {
        _B = B;
        _number = num;
        _time = time;
    }
}
class Station
{
    private string _name;
    public string name
    {
        get { return _name; }
    }
    private Train[] _trains = new Train[0];
    public Train[] trains
    {
        get { return _trains; }
    }
    public Station(string name)
    {
        _name = name;
    }
    public void addTrain(Train tr)
    {
        Train[] buf = new Train[_trains.Length + 1];
        for (int i = 0; i < _trains.Length; i++)
        {
            buf[i] = _trains[i];
        }
        buf[buf.Length - 1] = tr;
        _trains = buf;
    }
}