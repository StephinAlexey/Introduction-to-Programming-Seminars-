// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
void Main()
{
    char[,] CharMatrix=InitCharMatrix();
    DisplayCharMatrix(CharMatrix);
    System.Console.WriteLine(CharMatrixToString(CharMatrix));
}

char[,] InitCharMatrix()
{
    int Rows = TakeNumFromUser("Please write rows quantity:");
    int Columns = TakeNumFromUser("Please write clumns quantity:");
    char[,] CharMatrix = new char[Rows, Columns];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            CharMatrix[i, j] = RandomChar();
        }
    }

    return CharMatrix;
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
void DisplayCharMatrix(char[,] Matrix)
{
    int Rows = Matrix.GetLength(0);
    int Columns = Matrix.GetLength(1);
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            System.Console.Write($"{Matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
string CharMatrixToString(char [,]  CharMatrix)
{
    string str = "";
    foreach (char c in CharMatrix)
    {
        str+=c;
    }
    return str;
}
Main();