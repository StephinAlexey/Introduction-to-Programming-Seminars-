//Задача 3: Напишите программу, которая принимает на вход целое число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;
class Program
{
    static void Main(string[] args)
    {
        int num = InsertNumFromUser();
        Console.WriteLine($"The largest digit of the number {num} is: {FoundMaxDigitInNumber(num)}");
    }
    static int InsertNumFromUser()
    {
        while (true)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please write integer number in interval [10,99]: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 10 && num <= 99)
                    {
                        return num;
                    }
                    else
                    Console.WriteLine("The entered number is not in the required range [10, 99]");                    
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid iteger number");
            }
        }
    }
    static int FoundMaxDigitInNumber(int Number )
    {
        if(Number / 10 > Number % 10)
        {
            return Number / 10;
        }
        return Number % 10;

    }
}
