// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность двумерного массива mxn");
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)    //m=строки
{
    for (int j = 0; j < n; j++)   //n=столбцы
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double ar = 1;
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    ar=Math.Round(sum/matrix.GetLength(0),1);
    Console.Write(ar+"  ");
}
