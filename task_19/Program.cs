// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
string number=Convert.ToString(num);
int N=0;
 for (int i = 0; i < number.Length / 2; i++)
    if (number[i] != number[number.Length - 1 - i]) 
    {
        N=1;
    }
    else
    {
        N=2;
    }
if (N==1)
{
    Console.WriteLine("Число не является палиндромом");
}
else
{
    Console.WriteLine("Число является палиндромом");
}

