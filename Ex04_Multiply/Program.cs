// для любознательных: Написать программу премножения любых целых чисел
Console.Clear();
Console.WriteLine("Hello, World!");

int a = new Random().Next(1, 10000);
int b = new Random().Next(1, 200000);

int Multiply(int num1, int num2)
{
int answer = a*b;
return answer;
}

Console.WriteLine($"First number = {a}");
Console.WriteLine($"Second number = {b}");
Console.Write("Numbers multiply = ");
Console.WriteLine(Multiply(a,b));
