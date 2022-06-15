// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int prompt(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    int number = int.Parse(text);
    return number;
}

int num = prompt("Введите цифру от 1 до 7 , обозначающую день недели: ");
if (num < 1 || num > 7) { Console.WriteLine("Вы ввели неверную цифру, повторите попытку снова!"); }
else
{
    if (num < 6) { Console.WriteLine("Это рабочий день"); }
    else { Console.WriteLine("Ура, выходной!");  }
}
