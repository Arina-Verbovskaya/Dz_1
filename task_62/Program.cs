// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
Console.WriteLine("Введите размерность двумерного массива ");
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, m];
int num = 1;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        while (num <= m * m)
        {
            matrix[i, j] = num;
            if (i <= j + 1 && i + j < m - 1) ++j;
            else if (i < j && i + j >= m - 1) ++i;
            else if (i >= j && i + j > m - 1) --j;
            else --i;
            ++num;
        }
    }
}
Console.WriteLine();
PrintArray(matrix);
