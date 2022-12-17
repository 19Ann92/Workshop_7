// Дополнительная задача (задача со звёздочкой): Задайте двумерный 
// массив из целых чисел. Определите, есть столбец в массиве, 
// сумма которого, больше суммы элементов расположенных в четырех 
// "углах" двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, colums);
int sumCornerElements = GetSumOfCornerElements(array);
int[] array1 = GetSumOfColumnElements(array);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine(sumCornerElements);
Console.WriteLine($"{string.Join(",", (array1))}");
Console.WriteLine(CompareAmounts(array1, sumCornerElements) ? "Да" : "Нет");


int[,] FillArray(int arrayRows, int arrayColumns)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(1, 10);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
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

int GetSumOfCornerElements(int[,] array)
{
    int sumCornerElements = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumCornerElements = array[0, 0] + array[0, array.GetLength(1) - 1] + array[array.GetLength(0) - 1, 0] + array[array.GetLength(0) - 1, array.GetLength(1) - 1];
        }
    }
    return sumCornerElements;
}

int[] GetSumOfColumnElements(int[,] array)
{
    int sumColumnElements = 0;
    int index = 0;
    int[] newArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumnElements += array[i, j];
        }
        newArray[index] = sumColumnElements;
        index++;
        sumColumnElements = 0;
    }
    return newArray;
}

bool CompareAmounts(int[] array, int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > sum)
        {
            return true;
        }
             
    }
    return false;  
}