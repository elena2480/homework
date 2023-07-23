/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16   */


Console.Clear();

Console.Write("ВВедите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("ВВедите число B: ");
int b = int.Parse(Console.ReadLine());


Console.WriteLine($"{a} в степени {b} равно {MyMathPow(a,b)}");

int MyMathPow(int y, int x)
{
    if (y == 0) return 0;
    int degree = 1;
    for (int i = 1; i <= Math.Abs(x); i++) degree = degree * y;

   return degree;
}