// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*int prompt(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}
int number = prompt("Введите трехзначное число: ");
while (number <= 99 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    number = prompt("Введите трехзначное число");
}
int result = number / 100 * 10 + number % 10;

Console.WriteLine($"Without a second digit {number} is {result}");*/


int number = new Random().Next(99, 1000);
int result = number / 100 * 10 + number % 10;

Console.WriteLine($"Трехзначное число  {number}, без втрой цифры = {result}");