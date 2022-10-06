// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов на нечётных позициях.
Console.Clear();
Console.WriteLine("This program find sum ");

int[] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+", ");
    }
Console.WriteLine();
}

int Find_Sum(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i]%2>0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] numbers = CreateArray(10);

Fill(numbers, -100, 100);

Console.WriteLine("Array:");

Print(numbers);

Console.WriteLine($"Sum = {Find_Sum(numbers)}");
