// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int Fact(int num)
// {
//     if (num == 1)
//     {
//         return 1;
//     }
//     return num * Fact(num - 1);
// }
// int x = Fact(5);
// Console.WriteLine(x);

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int Nat(int num)
// {
//     if(num == 1)
//     {
//         return 1;
//     }
//     Console.Write(num);
//     return Nat(num - 1);
// }
// int x = Nat(num);
// Console.WriteLine(x);

// Задача 65: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int Nat(int N, int M)
// {
//     if(N == M)
//     {
//         return M;
//     }
//     Console.Write(N);
//     return Nat(N - 1, M);
// }
// int x = Nat(N, M);
// Console.WriteLine(x);

// Задача 67: Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Nat(int num)
{
    if(num % 10 == 0)
    {
       return 0; 
    }
    return (num % 10 + Nat(num / 10));
}
int x = Nat(num);
Console.WriteLine(x);
