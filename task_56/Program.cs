// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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
int[,] matrix = FillArray(m, n);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

void MinSumElements(int[,] matrix)
{
    int min = 0;
    int index = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < min)
        {
            min = sum;
            index = i;
        }
        sum = 0;
    }
    Console.Write($"{index+1} - строкa с наименьшей суммой ({min }) элементов ");
}
MinSumElements(matrix);



