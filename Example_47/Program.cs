// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(rows, columns);

Console.WriteLine();
PrintArray(array);

double[,] FillArray(int arrayRows, int arrayColumns)
{
    double[,] filledArray = new double[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = Math.Round(random.NextDouble() * (-10 - 10) + 10, 2);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
