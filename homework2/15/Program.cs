/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num<1 || num>7) {
    Console.WriteLine($"Ваше число {num} не попало в диапазон номеров дней недели [1,7]");
    return;
}
 if (num == 6 || num == 7) {
    Console.WriteLine($"{num} -> да");
 }
else {
    Console.WriteLine($"{num} -> нет");
}
