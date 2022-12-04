// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность двумерного массива mxn");
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)    //m=строки
{
    for (int j = 0; j < n; j++)   //n=столбцы
    {
        matrix[i, j] = new Random().Next(-11, 11) + rand.NextDouble();
        matrix[i,j] = Math.Round(matrix[i,j], 1);
        Console.Write(matrix[i, j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine();

