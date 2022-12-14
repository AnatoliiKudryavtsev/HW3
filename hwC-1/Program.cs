// Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число ");
        string? N = Console.ReadLine();

        int Num = Convert.ToInt32(N);
        int Num1 = Num / 10000;
        int Num5 = Num % 10;
        int Num2 = Num / 1000 - Num1 * 10;
        int Num3 = Num % 100;
        int Num4 = (Num3 - Num1) / 10;

        if (Num1 == Num5 & Num2 == Num4)
            Console.WriteLine("Число полином");
        else
            Console.WriteLine("Число {Num} НЕ полином");
    }
}                                                    