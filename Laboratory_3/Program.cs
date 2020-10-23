using System;
class MainClass
{

    static double number_x = Convert.ToDouble(Console.ReadLine());
    static double number_y = Math.Pow(number_x, 2);
    static string x = Convert.ToString(number_x);
    static string y = Convert.ToString(number_y);

    static void Border(string x, char start, char center, char end)
    {
        Console.Write(start);
        for (int i = 0; i < x.Length+2; i++)
        {
            Console.Write(center);
        }
        Console.Write(end);

        for (int i = 0; i < y.Length+2; i++)
        {
            Console.Write(center);
        }
        Console.WriteLine(end);
    }

    static void ContentX(string x, char start, char center)
    {
        Console.Write(start);
        Console.Write(' ' + x + ' ' + '|');
    }

    static void ContentY(string y, char start, char center)
    {
            Console.WriteLine(' ' + y + ' ' + '|');
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Выбери значение х для следующей функции!");
        Console.WriteLine("y=x^2");
        Border(x, '|', '-', '|');
        ContentX(x, '|', ' ');
        ContentY(y, '|', ' ');
        Border(x, '|', '-', '|');
        Console.ReadKey();
    }
}