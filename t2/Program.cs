// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

int[,] GenerateArray(int m, int n, int min, int max)
{int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = random.Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int[] SumOfString(int[,] array)
{
    int[] sumString = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumString[i] = sumString[i] + array[i, j];     
            }
        }
        return sumString;
}

int MinString(int[] sumString)
{
    int min = sumString[0];
    int minString = 0;
    for (int i = 0; i < sumString.Length; i++)
    {
        if (sumString[i] < min)
        {
            min = sumString[i];
            minString = i;
        }
    }

    return minString + 1;
}

int[,] array = GenerateArray(3, 4, 0, 9);
PrintArray(array);

Console.WriteLine();

int minStr = MinString(SumOfString(array)); 
Console.WriteLine($"номер строки с наименьшей суммой элементов: {minStr}");