// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во строк:");
int n = int.Parse(Console.ReadLine()!);
double[,] a = new double [m,n];
for (int i = 0;i<m;i++)
{
    for (int j =0;j<n;j++)
    {
        a[i,j] = new Random().Next(-10,10) + new Random().NextDouble();
        a[i,j] = Math.Round(a[i,j], 1);
        Console.Write($"{a[i,j]}; ");
    }
Console.WriteLine();
}