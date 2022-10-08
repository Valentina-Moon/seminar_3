//таблица квадрата чисел от 1 до N
Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int a =1;
while (a<=N)
{
    int b =a*a;
    Console.WriteLine($"a = {a}, квадрат числа a = {b}");
    a++;
}