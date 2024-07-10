namespace HW1;

class Program
{
    enum Colors : byte
    {
        Red = 0,
        Green = 1,
        Black = 2,
        White = 4
    }
    static void Main(string[] args)
    {
        Colors BlackWhite = Colors.Black | Colors.White;
        Console.WriteLine(BlackWhite);
    
    }
}
