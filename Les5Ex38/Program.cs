// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() + new Random().Next(-5, 6);
    Console.Write($"{Math.Round(array[i], 2)} ");
}
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = Math.Round(array[i], 2);
    if (array[i] < min) min = Math.Round(array[i], 2);
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Math.Round((max - min), 2)}");
