// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите число элементов массива: ");
int a = int.Parse(Console.ReadLine());

int[] array = GetArr(a);
Console.WriteLine($"{String.Join("; ", array)}");

int[] GetArr(int size) {
    int[] result = new int[size];
    int b = new Random().Next(0, 100);
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(-b, b);
    }
    return result;
}