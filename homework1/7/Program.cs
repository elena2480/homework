// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = Math.Abs(a % 10);
Console.Write($"{b} является третьей цифрой числа {a}");

