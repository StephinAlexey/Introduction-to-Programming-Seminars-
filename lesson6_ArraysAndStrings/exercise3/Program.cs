// Задание 3. Совместная работа
// Семинар 6. Массивы и строки
// 20 мин
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
void Main()
{
string ?str = Console.ReadLine();
System.Console.WriteLine($"Vowel's number is {VowelsCount(str!)}");
 
}
Main();
int VowelsCount(string text)
{
    int Counter=0;
    foreach (char item in text)
    {
        if(IsVowel(item))
        Counter++;
    }
    return Counter;
}
bool IsVowel(char c)
{
    return "eyuioaEYUIOA".Contains(c);
}