﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Nat(int N)
{
    if (N == 1)
    {
        return 1;
    }
    Console.Write(N);
    return Nat(N - 1);
}
int x = Nat(N);
Console.WriteLine(x);