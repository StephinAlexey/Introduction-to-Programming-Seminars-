namespace lesson2;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        System.Console.WriteLine("Ввведите число");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 99)
        {
            System.Console.WriteLine(result = num % 1000 / 100);
            
        }
        else
        {

            System.Console.WriteLine("Нет такого числа");
        }
    }
}
