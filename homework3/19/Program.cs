/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());

if (((a<10000) && (a>0)) || (a>99999)) {
    Console.WriteLine($"{a} не пятизначное число");
    return; 
}

if (a < 0) {
    Console.WriteLine("Отрицательное число не может быть палиндромом");
    return;
}


int a1 = a / 10000;            
int a2 = a / 1000 -a1 * 10;     
int a5 = a % 10;               
int a4 = (a % 100 - a5) / 10;   

if (a1 == a5 && a2 == a4) Console.WriteLine("Да");
else  Console.WriteLine("Нет");


