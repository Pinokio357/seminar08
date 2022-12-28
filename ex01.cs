using System;
int m = 3;
int n = 4;
int[,] matrix = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();

}
Console.WriteLine();
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


 void PrintArray(int[,] massiv)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{massiv[i, j]} ");
            }
            Console.WriteLine();
        }
    }

 PrintArray(matrix);


