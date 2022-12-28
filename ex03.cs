using System;

int m = 2;
int n = 2;
int[,] matrixB = new int[m, n];
int[,] matrixRezult = new int[m, n];
int[,] matrixA = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        matrixA[i, j] = rnd.Next(1, 10);
        Console.Write($"{matrixA[i, j]} ");

    }

    Console.WriteLine();

}
Console.WriteLine();
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        matrixB[i, j] = rnd.Next(1, 10);
        Console.Write($"{matrixB[i, j]} ");

    }

    Console.WriteLine();

}
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        int sum = 0;
        for (int k = 0; k < n; k++)
        {
            sum += matrixA[i, k] * matrixB[k, j];
        }

        matrixRezult[i, j] = sum;


    }

    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {

        Console.Write($"{matrixRezult[i, j]} ");

    }

    Console.WriteLine();

}



