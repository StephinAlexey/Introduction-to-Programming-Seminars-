// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//  Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.
using System.Globalization;

void Main()
{
    bool flag = false;
    (int, bool) value;
    while (!flag)
    {
        value = ReadInt();
        if (value.Item2)
            break;
        flag = CheckInput(value.Item1);
    }
}

(int, bool) ReadInt()
{
    (int, bool) Num = (0, false);
    string InString = "name";
    while (true)
    {

        Console.WriteLine("Please enter a number");
        try
        {
            InString = Console.ReadLine()!;
            Num.Item1 = Convert.ToInt32(InString);
            break;
        }
        catch (System.Exception)
        {
            try
            {
                if (Convert.ToChar(InString) == 'q')
                {
                    Num.Item2 = true;

                    break;
                }
            }
            catch
            {
                Console.WriteLine("Not valid number");
            }
        }

    }

    return Num;
}
bool CheckInput(int input)
{
    int sum = 0;
    int temp = input;
    int count = IntCounterDigits(input);
    int[] IntArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        sum += temp % 10;
        temp /= 10;
    }
    if (sum % 2 == 0)
        return true;
    else
        return false;
}
int IntCounterDigits(int Number)
{
    int Count = 0;
    for (Count = 0; Number != 0; Count++)
    {
        Number /= 10;
    }
    return Count;
}
Main();