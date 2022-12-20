/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Write("Введите размер массива: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out var value))
{
    Console.Error.WriteLine($"{str} не является числом");
    return;
}

int[] arr = new int[value];
Random rnd = new();
int posCount = 0;

for (int i = 0; i < value; i++)
    arr[i] = rnd.Next(100, 999);

Console.Write("Количество чётных чисел в сгенерированном массиве [");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i].ToString() + (i < arr.Length - 1 ? ", " : ""));
    if ((arr[i] % 2) == 0) posCount++;
}
Console.Write($"] равно {posCount}.");
