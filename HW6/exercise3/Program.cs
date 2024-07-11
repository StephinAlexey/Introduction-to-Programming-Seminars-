// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
void Main()
{
    string str = GetStringFromUser("Please insert text for checking if it is palindrome");
    if (IsPolindrom(str))
        System.Console.WriteLine("This is polindrome");
    else
        System.Console.WriteLine("This is not polindrome");

}

bool IsPolindrom(string str)
{
    int StrLength = str.Length;
    for (int i = 0; i < StrLength / 2; i++)
    {
        if (str[i] != str[StrLength - 1 - i])
        {
            return false;
        }
    }
    return true;
}
string GetStringFromUser(string TitleText)
{
    System.Console.WriteLine(TitleText);
    return Console.ReadLine()!;
}

Main();