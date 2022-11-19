// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите 3-х значное число:");  
int number= Convert.ToInt32(Console.ReadLine());
int digit1 = number / 100;
int digit2 = number % 10;
if (number>=100 && number <=999)
{
    Console.WriteLine($"Вторая цифры числа {number} это {(number-digit1*100-digit2)/10}");
}
else
{
    Console.WriteLine("Неверное число");
}