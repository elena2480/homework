//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число m>0: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n>0: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{MyAckerman(m,n)}");

int MyAckerman(int mum,int num)
{
    if (mum == 0) return (num +1);
      else
        if ((mum != 0)&&(num == 0))
            return MyAckerman((mum-1),1);
        else
            return MyAckerman((mum-1),MyAckerman(mum,(num-1)));
}