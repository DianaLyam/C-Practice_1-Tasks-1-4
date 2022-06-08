// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число1:");
string str1 = Console.ReadLine();
int a = int.Parse(str1);

Console.Write("Введите число2:");
string str2 = Console.ReadLine();
int b = int.Parse(str2);

Console.Write("Введите число3:");
string str3 = Console.ReadLine();
int c = int.Parse(str3);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write($"Максимальное число = {max}");
