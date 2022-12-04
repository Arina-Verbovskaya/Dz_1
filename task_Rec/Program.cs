// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5


int Rec(int n)
{
    if (n < 10)
    {
        return 1;
    }
    else
    {
        return Rec(n / 10) + 1;
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Rec(num));
