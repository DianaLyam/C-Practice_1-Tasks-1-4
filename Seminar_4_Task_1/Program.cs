//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int promptNumber (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int powerNat (int based, int power)
{
    int result = based;
    for (int i = 1; i<power; i++)
    {
       result=result*based;
    }
    return result;
}

int A = promptNumber("Введите число: ");
int B = promptNumber("Введите натуральную степень числа: ");
Console.WriteLine($"Число {A} в степени {B} равно {powerNat(A, B)}");

