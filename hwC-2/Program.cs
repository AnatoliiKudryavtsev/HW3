//Задача 21

//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X1  ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1  ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1  ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2  ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2 ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2  ");
int Zb = int.Parse(Console.ReadLine());

double Xab = (Xb - Xa);
double Yab = (Yb - Ya);
double Zab = (Zb - Za);

double XYZab = Math.Pow(Xab, 2) + Math.Pow(Yab, 2) + Math.Pow(Zab, 2);

double result = Math.Sqrt(XYZab);

Console.WriteLine($"расстояние  в 3D пространстве {result}");



