﻿//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write ("Enter N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
double sqr = 1;
while (N >= i )
{
    sqr = Math.Pow(i, 3);
    Console.Write($"{sqr}, ");
    i++;
}