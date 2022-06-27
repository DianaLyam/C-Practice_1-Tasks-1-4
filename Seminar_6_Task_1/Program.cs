﻿// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] InputNumbers(int M)
{
    int[] MNum = new int[M];
    for (int i = 0; i < M; i++)
    {
        MNum[i] = prompt($"Please input {i + 1} of {M} numbers ");
    }
    return MNum;
}
int CountNumberOfPositive(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if (el > 0) counter++;
    }
    return counter;
}


int M = prompt("How many numbers you would like to input? ");
int[] mynumbers = InputNumbers(M);
Console.WriteLine($"You wrote {CountNumberOfPositive(mynumbers)} positive numbers");
