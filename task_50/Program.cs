// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива mxn");
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое число:");
int num = Convert.ToInt32(Console.ReadLine());
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
int count = 0;
for (int i = 0; i < m; i++)    //m=строки
{
    for (int j = 0; j < n; j++)   //n=столбцы
    {
        if (matrix[i, j] == num)
        {
            count = 1;
        }
    }
}
if (count == 1)
{
    Console.Write("Такое число в массиве есть");
}
else
{
    Console.Write("Такого числа в массиве нет");
}



