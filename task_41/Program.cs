﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


char[] variants = { ' ', ',', '.' };
Console.Write("Введите числа через запятую ");


string? number = Console.ReadLine();
#nullable disable
int[] array = Array.ConvertAll(number.Split(variants), int.Parse);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);





