// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                matrix[i, j, k] = rand.Next(min, max);
            }
        }
    }
    return matrix;
}

void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("(" + i + "," + j + "," + k + ")" + array[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Укажите кол-во полей: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = FillMatrix(m, n, l, 10, 100);
ShowArray(array);
