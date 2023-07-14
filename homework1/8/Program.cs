// Задача 8:     Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



Console.Clear();

Console.Write("ВВедите натуральное число(положительное от 1): ");
int N = int.Parse(Console.ReadLine());
Console.Write($"Чётные числа от 1 до {N}: ");
if(N == 2)
    Console.Write($"{N}");

int i = 2;
while(i <= N)
{
    Console.Write($"{i} ");
     i = i + 2;
}

