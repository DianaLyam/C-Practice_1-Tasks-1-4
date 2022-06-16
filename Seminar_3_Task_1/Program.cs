//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string number = System.Console.ReadLine(); 
    return number;
}
string number=prompt("Введите пятизначное число: ");

if (number.Length != 5)
{
    Console.WriteLine($"{number} Введенное число не пятизначное, повторите попытку!");
}
else
{
    if (number[0]  == number[4] && number[1]  == number[3] ) 
    {
        Console.WriteLine($"{number} Ура, это палиндром!");
    }
    else
    {
        Console.WriteLine($"{number} Число не является палиндромом");
    }
}