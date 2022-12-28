using System;

int m = 4;
int n = 4;


int number = 1;


int[,] array = new int[m, n];


for (int y = 0; y < n; y++)
{
    array[0, y] = number;
    number++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = number;
    number++;
}
for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = number;
    number++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = number;
    number++;
}

for (int y = 1; y < n - 1; y++)
{
    array[1, y] = number;
    number++;
}


for (int x = n - 2; x >= 1; x--)
{
    array[m - 2, x] = number;
    number++;
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

PrintArray(array);
