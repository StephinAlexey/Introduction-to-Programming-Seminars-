//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
using System;

class Program
{
    static void Main()
    {
        Point InsertPoint()
        {
            Point num = new();
            while (true)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Please enter coordinate X: ");
                        num.X = Convert.ToInt32(Console.ReadLine());
                        if(num.X==0)
                        Console.WriteLine("This number cannot be zero");
                        else
                        break;
                      
                    }
                    while (true)
                    {
                        Console.WriteLine("Please enter coordinate Y: ");
                        num.Y = Convert.ToInt32(Console.ReadLine());
                        if(num.Y==0)
                        Console.WriteLine("This number cannot be zero");
                        else
                        break;
                    }
                    return num;

                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Not correctly input, must by number only");
                }
            }

        }

        int CoordinateQuarter(Point points)
        {
            if (points.X > 0)
            {
                if (points.Y > 0)
                    return 1;
                else if (points.Y < 0)
                    return 4;
            }
            else if (points.X < 0)
            {
                if (points.Y > 0)
                    return 2;
                else if (points.Y < 0)
                    return 3;
            }
            return 0; // Возвращает 0, если точка на одной из осей
        }

        Point MyPoint = InsertPoint();
        int num = CoordinateQuarter(MyPoint);
        switch (num)
        {
            case 1:
                // Действие для первой четверти
                Console.WriteLine($"Tочка ({MyPoint.X} , {MyPoint.Y}) относится к первой четверти системы координат");
                break;
            case 2:
                // Действие для второй четверти
                Console.WriteLine($"Tочка ({MyPoint.X} , {MyPoint.Y}) относится ко второй четверти системы координат");
                break;
            case 3:
                // Действие для третей четверти
                Console.WriteLine($"Tочка ({MyPoint.X} , {MyPoint.Y}) относится к третей четверти системы координат");
                break;
            case 4:
                // Действие для четвертой четверти
                Console.WriteLine($"Tочка ({MyPoint.X} , {MyPoint.Y}) относится к четвертой четверти системы координат");
                break;
            case 0:
                Console.WriteLine($"Tочка ({MyPoint.X} , {MyPoint.Y}) не относится к определённой четверти системы координат");
                break;
            default:
                // Действие для остальных случаев
                break;
        }
    }

    struct Point
    {
        public int X;
        public int Y;
    }
}
