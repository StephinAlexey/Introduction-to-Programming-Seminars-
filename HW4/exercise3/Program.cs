// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int ArrSize = TakeArraySizeFromUser();
    (int MinVal, int MaxVal) MinMax = GetMinMaxValFromUser();
    int[] IntArray = InitIntArray(ArrSize, MinMax.MinVal, MinMax.MaxVal);
    ArrayDisplay(IntArray, "The original array is:");
    int[] FlipedArray = FlipАrray(IntArray);
    ArrayDisplay(FlipedArray, "The flipped Array is:");
}
Main();
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
int[] FlipАrray(int[] Array)
{
    int tmp;
    for (int i = 0; i < Array.Length/2; i++)
    {
        tmp = Array[i];
        Array[i] = Array[Array.Length - 1 - i];
        Array[Array.Length - 1 - i] = tmp;
    }
    return Array;
}

(int MinVal, int MaxVal) GetMinMaxValFromUser()
{
    int MinVal = TakeNumFromUser("Please enter the minimum value for random ");
    int MaxVal;
    while (true)
    {
        MaxVal = TakeNumFromUser("Please enter the maximum value for random ");
        if (MaxVal > MinVal)
            break;
        else
            System.Console.WriteLine($"The maximum value must be bigger than {MinVal} ");
    }
    return (MinVal, MaxVal);
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
void ArrayDisplay(int[] IntArray, string DisplayText)
{
    System.Console.WriteLine(DisplayText);
    foreach (int item in IntArray)
    {
        System.Console.Write(item + " ");

    }
    System.Console.WriteLine();
}
int TakeArraySizeFromUser()
{
    int Size;
    while (true)
    {
        Size = TakeNumFromUser("Please enter array length");
        if (Size > 0)
            return Size;
        else
            System.Console.WriteLine("Size of array is not valid");
    }
}