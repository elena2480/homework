/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12   */




int GetSumNum(int a)
{
    int sum = 0;
    int c = 0;
    int n = Math.Abs(a);
        while (n > 0) 
        {
            c = n % 10;
            sum = sum + c;
            n = n / 10;
        }
return sum;
}

Console.Clear();
Console.Write("ВВедите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num} равна {GetSumNum(num)}");

/*int summa = 0;
int c = 0;
    int b = Math.Abs(num);
        while (b > 0) 
        {
            c = b % 10;
            sum = sum + c;
            b
             = b / 10;
        }  */