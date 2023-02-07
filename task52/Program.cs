// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double sum = 0.0;
double arif;
for (int i = 0; i < a.GetLength(1); i++)
{
    for (int j = 0; j < a.GetLength(0); j++)
    {
        sum += a[j, i];
    }
    arif = sum / a.GetLength(0);
    arif = Math.Round(arif, 1);
    Console.Write($"{arif}; ");
    sum = 0;
}