// Задание 1. Совместная работа
// Семинар 6. Массивы и строки
// 15 мин
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
void Main()
{
    char[] chars = { 'a', 'b', 'c', 'd' };
    //Version 1 (Used String consructor)
    // String str= new string(chars);
    // System.Console.WriteLine(str);

    //Version 2
    //System.Console.WriteLine(CharsToString(chars));

    //Version 3 (show array by method Join)
    //System.Console.WriteLine(string.Join("",chars));
    //version 4 (for connect arrays elements without separator like in Join method can ussing Concat method)
    System.Console.WriteLine(String.Concat(chars));
}
string CharsToString(char[] Chars)
{
    string str = "";
    foreach (char item in Chars)
    {
        str += item;

    }
    return str;
}
Main();
