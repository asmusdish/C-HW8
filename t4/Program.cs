// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray(int l, int m, int n)
{int[,,] array = new int[l, m, n];
Random random = new Random();
int[] numbers = new int[l * m * n];
for (int i = 0; i < numbers.Length; i++)
    {
        int number = random.Next(10, 100);
        if (numbers.Contains(number)) i--;
        else numbers[i] = number;
    }

    int f = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbers[f++];
            }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
                
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] array = GenerateArray(3, 2, 3);
PrintArray(array);