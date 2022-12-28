
using System;

int m = 4;
int n = 4;
int[] sums = new int[m];
int[,] matrix = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
        sum += matrix[i, j];
    }
    sums[i] = sum;
    Console.WriteLine();

}
Console.WriteLine();


int indexMin = 0;
int min = sums[0];
for (int i = 0; i < m; i++)
{
    if (sums[i] < min)
    {
        min = sums[i];
        indexMin = i;
    }


}

Console.WriteLine($"{indexMin + 1} string");

