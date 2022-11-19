// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X точки А ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки Б ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки Б ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки Б ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x=x1-x2;
int y=y1-y2;
int z=z1-z2;

double s=Math.Round((Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2))),2);
Console.WriteLine($"Расстояние между точками {s}");