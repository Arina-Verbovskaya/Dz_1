// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);
int sum = 0;
int firstNum = 0;
int D = 1;
if (num > 0)
{
    for (int i = 1; i <= number.Length; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
}
else
{
    for (int i = 0; i < number.Length - 2; i++)
    {
        D = D * 10;
    }
    firstNum = num / D;
    for (int i = 1; i <= number.Length - 2; i++)
    {
        sum = sum + Math.Abs(num) % 10;
        num = Math.Abs(num) / 10;
    }
    sum = sum + firstNum;
}
Console.WriteLine($"Сумма чисел равна: {sum}");
