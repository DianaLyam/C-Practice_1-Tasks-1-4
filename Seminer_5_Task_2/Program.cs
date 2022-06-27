// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


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

int SummaOddElements(int[] array)
{
    int SummaOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            SummaOdd += array[i];
        }
    }
    return SummaOdd;
}

int[] MyArray = CreateAndFillArray(6, 1, 50);
PrintArray(MyArray);
SummaOddElements(MyArray);
int sum = SummaOddElements(MyArray);
Console.Write($"Cумма элементов, стоящих на нечётных позициях = {sum}");