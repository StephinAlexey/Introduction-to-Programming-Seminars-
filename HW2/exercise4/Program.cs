//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
class Program
{
    static void Main(string[] args)
    {
        int NaturalNumber = InserNaturalNumFromUser(); 
        SortAndPrintDigitsOfNuturalNum(NaturalNumber);
 
    }
    static int InserNaturalNumFromUser()
    {
        while (true)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter a natural number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        return num;
                    }
                    else
                        Console.WriteLine("A natural number is a number that is greater than zero");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number");
            }
        }
    }
    static void SortAndPrintDigitsOfNuturalNum(int Num)
    {
        int tmp_num = Num;
        int counter=-1;
        List <int> NumList = new List <int> ();
        while(tmp_num!=0)
        {   
            NumList.Add((tmp_num % 10));
            tmp_num/=10;
            counter++;
        }
        for (int i = counter; i > 0; i--)
        {
            Console.Write($"{NumList[i]} , ");
        }
            Console.Write($"{NumList[0]}");

        
    }
}
