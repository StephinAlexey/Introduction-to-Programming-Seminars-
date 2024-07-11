// Задача 4*(не обязательная): Задайте строку, состоящую из слов,
// разделенных пробелами. Сформировать строку, в которой слова расположены
// в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
void Main()
{
    string str = GetStringFromUser("Please insert a sentence in which the words are separated by spaces");
    string[] StringArray = ConvertStringToStringsArray(" ", str);
    InvertStringArray(StringArray);
    string SolutionString = ConvertStringArrayToString(StringArray);
    System.Console.WriteLine($"The solution string is: \n{SolutionString}");
}
string GetStringFromUser(string TitleText)
{
    System.Console.WriteLine(TitleText);
    return Console.ReadLine()!;
}
string[] ConvertStringToStringsArray(string Separator, string SourceString)
{
    string[] StringsArray = SourceString.Split(Separator);
    return StringsArray;
}
void InvertStringArray(string[] StringArray)
{
    string tmp = "";
    for (int i = 0; i < StringArray.Length / 2; i++)
    {
        tmp = StringArray[i];
        StringArray[i] = StringArray[StringArray.Length - 1 - i];
        StringArray[StringArray.Length - 1 - i] = tmp;
    }
}
string ConvertStringArrayToString(string[] StringArray)
{
    return string.Join(" ",StringArray);
}

Main();