// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)    
                {
                    for (int k = 0 ; k < matrix1.GetLength(1); k++)
                    {
                         matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
                    }
                }
        }
        return matrix3;
}

int[,] matrix1 = GenerateArray(2, 3, 0, 3);
PrintArray(matrix1);

Console.WriteLine();

int[,] matrix2 = GenerateArray(3, 2, 0, 3);
PrintArray(matrix2);

Console.WriteLine();

int[,] matrix3 = Multiplication(matrix1, matrix2); 
PrintArray(matrix3);