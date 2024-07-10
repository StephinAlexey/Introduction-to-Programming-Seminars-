// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization.Formatters;

void Main()
{

    int Rows = TakeNumFromUser("Write matrix rows number");
    int Columns = TakeNumFromUser("Write matrix columns number");
    (int min, int max) MinMax = GetMinMaxValFromUser();
    int[,] Matrix = CreateRandomMatrix(Rows, Columns, MinMax.min, MinMax.max);
    List<(int x, int y)> MinElemIndex = GetMinElemIndex(Matrix);
    DisplayIntMatrix(Matrix);
    DisplayIndexList("The min element index is: ", MinElemIndex);
    (List<int> RowList, List<int> ColumnList) RowsColumns = GetUniqRowColumnsArray(MinElemIndex);
    DisplayIntList(RowsColumns.RowList,"Rows for deleting");
    DisplayIntList(RowsColumns.ColumnList,"Columns for deleting");
    int[,] NewMatrix = DeleteRowsColumns(RowsColumns.RowList,RowsColumns.ColumnList,Matrix);
    DisplayIntMatrix(NewMatrix);

}
void DisplayIntList(List <int> ShowList,string ShowTxt)
{
    System.Console.WriteLine(ShowTxt);
    foreach (int item in ShowList)
    {
        System.Console.WriteLine(item);
    }
}
int[,] CreateRandomMatrix(int rows, int columns, int RndMin, int RndMax)
{
    int[,] Mtx = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Mtx[i, j] = rnd.Next(RndMin, RndMax);
        }
    }
    return Mtx;
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
List<(int, int)> GetMinElemIndex(int[,] Matrix)
{
    List<(int, int)> Points = new List<(int, int)>();
    (int x, int y) Point = (0, 0);
    int Rows = Matrix.GetLength(0);
    int Columns = Matrix.GetLength(1);

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            if (i == 0 && j == 0)
                j = 1;
            if (Matrix[i, j] < Matrix[Point.x, Point.y])
            {
                Point = (i, j);
                Points.Clear();
                Points.Add(Point);
            }
            else
            if (Matrix[i, j] == Matrix[Point.x, Point.y])
            {
                Point = (i, j);
                Points.Add(Point);
            }

        }
    }
    return Points;
}
void DisplayIntMatrix(int[,] Matrix)
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
void DisplayIndexList(string Title, List<(int x, int y)> IndxList)
{
    Console.WriteLine(Title);
    foreach ((int x, int y) Point in IndxList)
    {
        System.Console.WriteLine($"Row: {Point.x}, Column: {Point.y}");
    }
}
(List<int> RowList, List<int> ColumnList) GetUniqRowColumnsArray(List<(int x, int y)> ElemIndexes)
{
    List<int> RowList = new List<int>();
    List<int> ColumnList = new List<int>();
    List<int> RowList1 = new List<int>();
    List<int> ColumnList1 = new List<int>();


    foreach ((int row, int column) item in ElemIndexes)
    {
        RowList.Add(item.row);
        ColumnList.Add(item.column);

    }
    while(RowList.Count>0)
    {
        int tmp=RowList[0];
        RowList.RemoveAll(x => x == tmp);  
        RowList1.Add(tmp);

    }
    while (ColumnList.Count>0)
    {
        int tmp=ColumnList[0];
        ColumnList.RemoveAll(y => y == tmp);
        ColumnList1.Add(tmp);

    }
    return (RowList1, ColumnList1);
}
int[,] DeleteRowsColumns(List<int> rows, List<int> columns, int[,] OldMetrix)
{
    bool flag_x = true;
    bool flag_y = true;
    int[,] NewMatrix = new int[(OldMetrix.GetLength(0) - rows.Count<int>()), (OldMetrix.GetLength(1) - columns.Count<int>())];
    int NewMtxRows = NewMatrix.GetLength(0);
    int NewMtxColumns = NewMatrix.GetLength(1);
    int OldMtxRowsCounter = OldMetrix.GetLength(0);
    int OldMtxColumnsCounter = OldMetrix.GetLength(1);
    for (int i = 0, i1 = 0; i < OldMtxRowsCounter; i++)
    {

        foreach (int item in rows)
        {
            if (item == i)
                flag_x = false;
        }
        if(flag_x)
        for (int j = 0, j1 = 0; j < OldMtxColumnsCounter; j++)
        {
            foreach (int item in columns)
            {
                if (item == j)
                    flag_y = false;
            }
            if(flag_y)
            {
            NewMatrix[i1,j1] = OldMetrix[i,j];
            j1++;
            }
            flag_y=true;

        }
        if(flag_x)
        i1++;
        else
        flag_x=true;

    }
    return NewMatrix;

}
Main();