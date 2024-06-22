// System.Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b)
// { Console.WriteLine($"b = {b}, a = {a} => Yes"); }
// else
// {
//     if (b == a * a)
//     {
//         Console.WriteLine($"b = {b}, a = {a} => Yes");
//     }
//     else
//         Console.WriteLine($"b = {b}, a = {a} => No");

// }


int InsertNumFromUser(string DescriptForNumberInsert)
{
    System.Console.WriteLine(DescriptForNumberInsert);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Number = InsertNumFromUser("Введите пограничное число");
if (Number < 0) Number = -Number;
for (int i = Number; i > -Number; i--)
    System.Console.Write(i+", ");
System.Console.WriteLine(-Number);