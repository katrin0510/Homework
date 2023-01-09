Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
Console.WriteLine("x = от 1 до + бесконечности");
Console.WriteLine("y = от 1 до + бесконечности");  
}
if (num == 2)
{
Console.WriteLine("x = от -1 до - бесконечности");
Console.WriteLine("y = от 1 до + бесконечности");
}
if (num == 3)
{
Console.WriteLine("x = от -1 до - бесконечности");
Console.WriteLine("y = от -1 до - бесконечности");
}
if (num == 4)
{
Console.WriteLine("x = от 1 до + бесконечности");
Console.WriteLine("y = от -1 до - бесконечности");
}
if (num < 1)
{
Console.WriteLine( "введите значение от 1 до 4");
}

if (num > 4)
{
Console.WriteLine( "введите значение от 1 до 4");
}

