// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if ((num > 99)&&(num < 1000))
{
    Console.Write("Третьей цифрой является: ");
    Console.WriteLine(num % 10);
}
else if (num > 999)
{
    while (num > 999)
    {
     num = num / 10;   
    }
    Console.Write("Третьей цифрой является: ");
    Console.WriteLine(num % 10);
}


