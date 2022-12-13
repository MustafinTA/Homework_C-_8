// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 3];

FillMatrix(array);
PrintMatrix(array);
System.Console.WriteLine();

Console.WriteLine();
int[] summaElementsRow = SummaElementsRow(array);
Console.WriteLine();
(int, int) theSmallestSummaRow = TheSmallestSummaRow(summaElementsRow);
Console.WriteLine($"Наименьшаяя сумма, строка: {theSmallestSummaRow}");

int[] SummaElementsRow(int[,] matrix)
{
    int[] summaElements = new int[matrix.GetLength(0)];
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
            summaElements[i] = summa;
        }
        summa = 0;
    }
    return summaElements;
}

(int, int) TheSmallestSummaRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i + 1;
        }
    }
    return (resultSumma, resultRow);
}

int[,] FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}