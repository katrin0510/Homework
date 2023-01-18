// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
    if (i % 2 != 0)
       sum = sum + array[i];
}
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечётных позициях: {sum}");
