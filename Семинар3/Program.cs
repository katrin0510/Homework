
// 39) Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int[] Array()
// {
//     int[] array = new int[new Random().Next(2, 5)];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//         Console.Write($"{array[i]} ");
//     }
//     return array;
// }

int[] array = {1, 2, 3, 4, 5};
for (int i = 0; i < array.Length / 2; i++)
{
  int temp = array[i];
  array[i] = array [array.Length - 1 - i];
  array [array.Length - 1 - i] = temp;
}

void PrintArray() {

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}
PrintArray();



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// System.Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// string res = "" ;
// int n =num;
// while(n >0)
// {  
//     res = n%2+ res;
//     n=n/2;
// }
// System.Console.WriteLine(res);


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// (b+c)>a) не доделано
// {
//     System.Console.WriteLine("Треугольник существует!");
// }
// else{
//     System.Console.WriteLine("Не существует!");
// }

