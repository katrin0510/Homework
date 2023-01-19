// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 6);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    result = sum / array.GetLength(0);
    Console.Write($"{Math.Round (result, 2)} ");
}