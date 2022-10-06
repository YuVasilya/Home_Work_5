// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();


double [] CreateArray(int size)
{
    return new double[size];
}

void Fill(double[] array, int minValue, int maxValue)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void Print(double [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.WriteLine();
}

double Find_Max(double[] array)
{
    int size = array.Length;
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if(array[i]>max) max = array[i];
    }
    return max;
}

double Find_Min(double[] array)
{
    int size = array.Length;
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if(array[i]<min) min = array[i];
    }
    return min;
}

double Max_minus_Min(double max, double min)
{
    double answer = max - min;
    return answer;
}

Console.WriteLine("Hello!");

double[] numbers = CreateArray(10);
Fill(numbers, -100, 101);
Print(numbers);
double max = Find_Max(numbers);
double min = Find_Min(numbers);
double minus = Max_minus_Min(max, min);
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"max minus min = {minus}");