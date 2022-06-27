// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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

int FindeDefferenceBetweenMaxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    int difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    difference = max - min;
    return difference;
}

int[] MyArray = CreateAndFillArray(6, 1, 50);
PrintArray(MyArray);
FindeDefferenceBetweenMaxAndMin(MyArray);
var dif  = FindeDefferenceBetweenMaxAndMin(MyArray);
Console.Write($"разница между максимальным и минимальным элементом массива = {dif}");