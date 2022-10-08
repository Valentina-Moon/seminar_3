// Введите число A в натуральную степень B используя цикл.
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
int C = 1;
while (count<B)
{
    C = C * A;
    count++;
}
Console.WriteLine($"Число {A} в степени {B} равно : {C}");
