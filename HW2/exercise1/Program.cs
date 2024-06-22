
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


namespace exercise1;

class Program
{

    static void Main(string[] args)
    {
        ProjectFunctions Funct = new ProjectFunctions();
        int DivNum1 = 7;
        int DivNum2 = 23;
        int num = Funct.InsertNumFromUser();
        if (Funct.IsMultiple(num, DivNum1, DivNum2))
            Console.WriteLine($"Число {num} кратно числам {DivNum1} и {DivNum2} одновременно");
        else
            Console.WriteLine($"Число {num} не кратно числам {DivNum1} и {DivNum2} одновременно");

    }



}
class ProjectFunctions
{
    public int InsertNumFromUser()
    {
        Console.WriteLine("Please write integer number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }
    public bool IsMultiple(int CheckedNum, int DivNum1, int DivNum2)
    {
        if ((CheckedNum % DivNum1 == 0) && (CheckedNum % DivNum2 == 0))
            return true;
        return false;
    }
}

