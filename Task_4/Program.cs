// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число:");
string str1 = Console.ReadLine();
int N = int.Parse(str1);
int i = 1;
if (N > 0)
{
    while (i <= N)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;

    }
}
else
{
    while (i >= N)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i = i-1;

    }
}