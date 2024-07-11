// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
void Main()
{
    string str = "Hello!";
    char[]? chars = null;
    //Version 1 (using ToCharArray method)
    //chars = str.ToCharArray();

    //Version 2 
    chars = StringToCharArray(str);

    DisplayCharArray(chars);
}
Main();
void DisplayCharArray(char[] Array)
{
    System.Console.WriteLine(string.Join(",", Array));
}
char[] StringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
        chars[i] = str[i];
    return chars;
}