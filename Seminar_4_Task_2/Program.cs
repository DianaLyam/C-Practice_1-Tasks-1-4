//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int promptNumber (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigits (int number)
{
    int digits = 0;
    while (number > 0) 
    {
        digits=digits+number%10; 
        number = number / 10; 
    }
    return digits;
}

int number = promptNumber("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");
