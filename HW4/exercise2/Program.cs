// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Main()
{
    int Size = TakeArraySizeFromUser();
    (int MinVal,int MaxVal) MinMax;
    MinMax = GetMinMaxValFromUser();
    int[] IntArray = InitIntArray(Size, MinMax.MinVal, MinMax.MaxVal);
    (int Even, int Odd) Counter;
    Counter = CalcEvenOddNumbers(IntArray);
    ArrayDisplay(IntArray,"The array is");

    Console.WriteLine($"The even numbers counter is {Counter.Even}");
    Console.WriteLine($"The odd numbers counter is {Counter.Odd}");


}

Main();

void ArrayDisplay(int[] IntArray, string DisplayText)
{
        System.Console.WriteLine(DisplayText);
    foreach(int item in IntArray)
    {
        System.Console.Write(item+" ");
        
    }
    System.Console.WriteLine();
}

(int MinVal,int MaxVal) GetMinMaxValFromUser()
{
    int MinVal = TakeNumFromUser("Please enter the minimum value for random ");
    int MaxVal;
    while(true)
    {
     MaxVal = TakeNumFromUser("Please enter the maximum value for random ");
     if(MaxVal>MinVal)
     break;
     else
     System.Console.WriteLine($"The maximum value must be bigger than {MinVal} ");
    }
    return (MinVal,MaxVal);
}
int[] InitIntArray(int Size, int MinVal, int MaxVal)
{
    Random rnd = new();
    int[] IntArray = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        IntArray[i] = rnd.Next(MinVal, MaxVal);
    }
    return IntArray;
}

(int Even, int Odd) CalcEvenOddNumbers(int[] IntArray)
{
    int Odd = 0;
    int Even = 0;
    foreach (int item in IntArray)
    {
        if (item % 2 == 0)
            Even++;
        else
            Odd++;
    }
    return (Even, Odd);
}

int TakeArraySizeFromUser()
{
    int Size;
    while(true)
    {
        Size=TakeNumFromUser("Please enter array length");  
        if(Size>0)
        return Size;
        else
        System.Console.WriteLine("Size of array is not valid");
    }
}

int TakeNumFromUser(String TextForUser)
{
    while (true)
    {
        try
        {
            Console.WriteLine(TextForUser);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter a valid iteger number");
        }
    }
}