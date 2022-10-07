//колличество цифр в числе
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
while (num > 0)
{
    i++;
    num = num / 10;
}
Console.WriteLine("Количество цифр введенного числа : " + i);