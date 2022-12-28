using System;

int x = 2;
int y = 2;
int z = 2;
int count = x * y * z;
int[] arrayRandom = new int[count];
Random rnd = new Random();





for (int i = 0; i < count;)
{
    bool control = false;
    int temp = rnd.Next(10, 100);

    for (int j = 0; j < i; j++)

    {

        if (arrayRandom[j] == temp)
        {
            control = true;

        }
    }

    if (!control)
    {
        arrayRandom[i] = temp;
        i++;
    }
    else
    {
        i -= 1;
    }
}


int[,,] matrix3d = new int[x, y, z];
int l = 0;
for (int i = 0; i < x; i++)
{

    for (int j = 0; j < y; j++)
    {

        for (int k = 0; k < z; k++)
        {
            matrix3d[i, j, k] = arrayRandom[l];
            Console.Write($"{matrix3d[i, j, k]} ({i}, {j}, {k})");
            l++;
        }

        Console.WriteLine();

    }


}



