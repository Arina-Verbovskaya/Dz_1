// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размерность двумерного массива mxn");
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = FillArray(m, n);
int[,] B = FillArray(m, n);
Console.WriteLine();
PrintArray(A);
Console.WriteLine();
PrintArray(B);
int [,] DivArray(int[,] A, int[,] B)
{
    int[,] matrix = new int[A.GetLength(0), B.GetLength(1)];
    if (A.GetLength(0) == B.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
                for (int n = 0; n < A.GetLength(1); n++)
                {
                    matrix[i, j] += A[i, n] * B[n, j];
                }
            }
        }
    }
     return matrix;
}
Console.WriteLine();
PrintArray(DivArray(A, B));

