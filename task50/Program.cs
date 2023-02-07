// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] a = new int[3, 4];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(0, 10);
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число, которое хотите найти:");
int b = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (a[i, j] == b)
        {
            Console.WriteLine($"{i},{j}");
            sum += 1;
        }
    }
}
if (sum == 0) { Console.WriteLine("Такого числа в массиве нет"); }