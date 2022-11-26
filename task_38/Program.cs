// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] Array(int size)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10) + rand.NextDouble();
        arr[i] = Math.Round(arr[i], 3);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = Array(N);
Console.WriteLine("[" + string.Join(", ", array) + "]");
double max = array[0];
double min = array[1];
double diff = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значением массива равна: {diff}");
