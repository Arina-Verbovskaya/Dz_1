// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("b1=");
double b1=Convert.ToInt32(Console.ReadLine());
Console.Write("b2=");
double b2=Convert.ToInt32(Console.ReadLine());
Console.Write("k1=");
double k1=Convert.ToInt32(Console.ReadLine());
Console.Write("k2=");
double k2=Convert.ToInt32(Console.ReadLine());
double x=Math.Round((b2-b1)/(k1-k2),2);
double y=Math.Round(k1*x+b1,2);
double[] arr=new double[2];
arr[0]=x;
arr[1]=y;
Console.WriteLine("(" + string.Join(", ", arr) + ")");





