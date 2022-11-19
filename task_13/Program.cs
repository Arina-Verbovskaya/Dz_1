// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число:");
int num1=Convert.ToInt32(Console.ReadLine());
int num=Math.Abs(num1);
string number=Convert.ToString(num);
if (number.Length>=3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
