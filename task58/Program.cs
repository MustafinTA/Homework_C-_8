// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

int[,] matrix  = new int[2, 2];
int[,] matrix2 = new int[2, 2];

Console.WriteLine("Первая матрица");
FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
Console.WriteLine("Вторая матрица");
FillMatrix2(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine(@CheckMatrix(matrix, matrix2) ? "Результат перемножения матриц ": "");
int[,] multiplyTwoMatrix = MultiplyTwoMatrix(matrix, matrix2);
PrintMatrix(multiplyTwoMatrix);

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1 ,10);
        }
    }
    return matrix;
}

int[,] FillMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

bool CheckMatrix(int[,] matrix, int[,] matrix2)
{
    return (matrix.GetLength(1) == matrix2.GetLength(0));
}

int[,] MultiplyTwoMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyTwoMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (CheckMatrix(matrix, matrix2) == true)
    {
        for (int i = 0; i < multiplyTwoMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyTwoMatrix.GetLength(1); j++)
            {
                multiplyTwoMatrix[i, j] =  0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyTwoMatrix[i, j] += matrix [i, k] * matrix2[k, j];
                }
            }
        }
    }
    return multiplyTwoMatrix;
}


