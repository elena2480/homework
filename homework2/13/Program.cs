/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int a = Math.Abs(num);

if (a<100) {
    Console.WriteLine($"В числе {num} нет третьей цифры");
    return;
}
int i = a;
while (i > 999) {
    i = i/10;
}
 Console.WriteLine($"Третья слева цифра числа {num} -> {i%10}");