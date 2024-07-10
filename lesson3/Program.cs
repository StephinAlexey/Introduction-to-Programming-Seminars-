using System.ComponentModel;

namespace lesson3;

class Program
{
    static void Main(string[] args)
    {
        // string name1 = "Ivan";
        // string name2 = "Victoria";
        // string name3 = "Denis";
        string[] names = { "Ivan", "Victoria", "Denis" };
        string[] names1 = { "Ivan", "Victoria", "Denis", "Tolya" };
        //string str = Console.ReadLine(); // "12 32 12 32 12"
        //string[] strArray = str.Split(" "); // {"12", "32", "12", "32", 12}
        int[] numbersfromstr = Array.ConvertAll(Console.ReadLine()!.Split(","),Convert.ToInt32);
        // string path = "D:\\example1.txt";
        // using (StreamWriter writer = new StreamWriter(path))
        // {
        //     writer.WriteLine("Привет, мир!");
        // }

        // Добавляем текст в существующий файл
        // using (StreamWriter writer = new StreamWriter(path, append: true))
        // {
        //     for (int i = 0; i < 2000000000; i++)
        //         writer.WriteLine("Продолжение текста...");
        // }
        //string[] names3 = names.Concat(names1)
        foreach (var item in numbersfromstr)
        {
            System.Console.WriteLine(item);


        }
        // double[] numbers = new double[5];
        // Random rand = new Random();
        // for (int i = 0; i<numbers.Length;i++)
        // {
        //     numbers[i] = rand.Next(0,10) + Math.Round(rand.NextDouble(), 3);
        // }
        // foreach (double item in numbers)
        // {
        //     System.Console.WriteLine(item);
        // }

    }
}
