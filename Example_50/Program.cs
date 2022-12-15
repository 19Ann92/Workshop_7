// Задача 50. Напишите программу, которая на вход принимает 
// индексы элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс строки искомого элимента: ");
int indexI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца искомого элимента: ");
int indexJ = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, colums);
int resalt = FindPosition(array);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();

if (indexI < array.GetLength(0) && indexJ < array.GetLength(1)) 
{
    Console.WriteLine(resalt);
}
else 
{
    Console.WriteLine($"{indexI}, {indexJ} -> элемента с данными индексами в массиве нет");
}

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

int FindPosition(int[,] array)
{
    int position = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == indexI && j == indexJ)
            {
                position = array[i, j];
            }
        }
    }
    return position;
}