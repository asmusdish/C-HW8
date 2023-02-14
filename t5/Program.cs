// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    int k = 1;
    int t = 0;
    int i, j = 0;
    int n1 = n;
    int m1 = m;

    while (k <= n1 * m1)
    {
        for (i = t; i < n; i++)
            array[j, i] = k++;
            j = n - 1;
        for (i = t + 1; i < m; i++)
            array[i, j] = k++;
            j = m - 1;
        for (i = n - 2; i >= t; i--)
            array[j, i] = k++;
            j = t;
        for (i = m - 2; i > t; i--)
            array[i, j] = k++;
            n--;
            m--;
            t++;
            j = t;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("0.#") + "\t");
        Console.WriteLine();
    }
}

int[,] result = GenerateArray(4, 4);
PrintArray(result);
