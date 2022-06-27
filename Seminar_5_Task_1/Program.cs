// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateAndFillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}  ");
    }
    Console.WriteLine();
}

int SearchNumbersInLine(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] MyArray = CreateAndFillArray(10, 100, 1000);
PrintArray (MyArray);
int count = SearchNumbersInLine(MyArray);
Console.Write($"Количество чётных чисел в массиве = {count}");