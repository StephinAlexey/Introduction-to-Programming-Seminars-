// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void Main()
{
string str = MakeRandomString(TakeNumFromUser("Please write the symbols amount in random string:"));
System.Console.WriteLine($"Old string:\n{str}");
string str_lower = str.ToLower();
System.Console.WriteLine($"Modificated string is:\n{str_lower}");
}

string MakeRandomString(int SymbolsNum)
{
    string str = "";
    for (int i = 0; i < SymbolsNum; i++)
    {
        str += RandomChar();
    }
    return str;
}
char RandomChar()
{
    string chars = "12344567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    return (chars[new Random().Next(chars.Length)]);
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

Main();