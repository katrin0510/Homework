// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 100);

//         Console.Write($"{array[i, j]} ");

//     }
//     Console.WriteLine();
// }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;

//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-10, 10);
//         if (i % 2 == 0 && j % 2 == 0)
//             array[i, j] = array[i, j] * array[i, j];




//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// int summ = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-10, 10);
//         if (i == j)
//             summ = summ + array[i, j];

//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
//  Console.Write($"Сумма элементов равна {summ} ");

// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа

int x1 = new Random().Next(1,300);
int x2 = new Random().Next(1,300);
int x3 = new Random().Next(1,300);
int x4 = new Random().Next(1,300);
int x5 = new Random().Next(1,300);
{
Console.WriteLine(Math.Pow(x1,5) + Math.Pow(x2,5) + Math.Pow(x3,5) + Math.Pow(x4,5)) = Math.Pow(x5,5);

}

