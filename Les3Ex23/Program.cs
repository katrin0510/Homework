// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int index = 0; index < num; index++)
{
array[index] = (index + 1) * (index + 1) * (index +1);
Console.Write(array[index]);
}


