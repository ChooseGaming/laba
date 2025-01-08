using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Сколько будет студентов?");
        Student[] students = new Student[int.Parse(Console.ReadLine())];
        Console.Clear();
        int answer = 0;
        do
        {
            bool checker = false;
            PMenu();
            answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = fillST();
                }
            } else if (answer == 2)
            {
                Console.WriteLine("Введите ФИО");
                string fio = Console.ReadLine();
                for (int i = 0; i < students.Length; i++)
                {
                    
                    if (students[i].fio == fio)
                    {
                        students[i] = fillST();
                        checker = true;
                    }
                }
                if (!checker) Console.WriteLine("Совпадений не найдено");
            }
            else if (answer == 4)
            {
                Console.WriteLine("Введите год рождения");
                int age = int.Parse(Console.ReadLine());
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].birth == age)
                    {
                        Console.WriteLine($"{students[i].fio} - {students[i].birth} - {students[i].course}");
                        checker = true;
                    }
                }
                if (!checker) Console.WriteLine("Совпадений не найдено");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Введите курс");
                int c = int.Parse(Console.ReadLine());
                for (int i = 0; i < students.Length; i++)
                {
                    //Console.WriteLine(students[i].course);
                    if (students[i].course == c)
                    {
                        Console.WriteLine($"{students[i].fio} - {students[i].birth} - {students[i].course}");
                        checker = true;
                    }
                }
                if (!checker) Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();
        } while (answer != 5);
    }

    static void PMenu()
    {
        Console.WriteLine("1. Заполнение");
        Console.WriteLine("2. Модификация по ФИО");
        Console.WriteLine("3. Вывод всех студентов по курсу");
        Console.WriteLine("4. Вывод всех студентов по дате рождения");
        Console.WriteLine("5. Выход");
    }
    static Student fillST()
    {
        Console.WriteLine("Введите ФИО студента через пробел");
        string fio = Console.ReadLine();
        Console.WriteLine("Введите год рождения");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите курс");
        int course = int.Parse(Console.ReadLine());
        return new Student(fio, age, course);
    }
}

class Student
{
    private string _name,_lname,_Dname;
    private int _birth_date, _course;

    public Student(string fio, int birth_date, int course)
    {
        string[] f_i_o = fio.Split(' ');
        _name = f_i_o[1];
        _lname = f_i_o[0];
        _Dname = f_i_o[2];
        _birth_date = birth_date;
        _course = course;
    }

    public string fio
    {
        get
        {
            return $"{_lname} {_name} {_Dname}";
        }
        private set
        {
            string[] f = value.Split(' ');
            _name = f[1];
            _lname = f[0];
            _Dname = f[2];
        }
    }
    public int birth
    {
        get
        {
            return _birth_date;
        }
        private set
        {
            _birth_date = value;
        }
    }
    public int course
    {
        get
        {
            return _course;
        }
        private set
        {
            _course = value;
        }
    }
}