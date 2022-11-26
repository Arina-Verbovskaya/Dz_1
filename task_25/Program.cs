// напишите цикл, который принимает на вход 2(А и Б) числа и возводит число А в натуральную степень Б
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > 0 & numberB > 0)
{
    int sqrt = 1;
    for (int i = 1; i <= numberB; i++)
    {
        sqrt = sqrt * numberA;
    }
    Console.WriteLine(sqrt);
}
else
{
    Console.WriteLine("Неверное число, введите положительные числа");
}


