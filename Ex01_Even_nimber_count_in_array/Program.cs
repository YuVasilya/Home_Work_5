// Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет колличество чётных числе в массиве.
Console.Clear();

int [] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array, int minValue, int maxValue)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void Print(int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.WriteLine();
}

int Count_Even_Num(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


Console.WriteLine("Hello, Teacher");

int numlen = new Random().Next(1, 101);
Console.WriteLine($"array.Length = {numlen}");

int [] numbers = CreateArray(numlen);

Fill(numbers, 100, 1000);

Print(numbers);

Console.WriteLine($"Count even numbers = {Count_Even_Num(numbers)}");

