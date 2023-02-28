// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

int[,] PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine();
    }
    return matr;
}

int[,] MultiplyArray(int[,] matr1, int[,] matr2)
{

    int[,] massive = new int[matr1.GetLength(0), matr2.GetLength(1)];

    if (matr1.GetLength(1) != matr2.GetLength(0)) Console.WriteLine("Enter column massive 2 equal string massive 1");
    else
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                massive[i, j] = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    massive[i, j] += matr1[i, k] * matr2[k, j];
                }
            }
        }
    }
    return massive;
}

int m = EnterData("Enter string massive 1:");
int n = EnterData("Enter column massive 1:");
int[,] array1 = new int[m, n];

FillArray(array1);
Console.WriteLine("Massive 1:");
PrintArray(array1);
Console.WriteLine();
int v = EnterData("Enter string massive 2:");
int b = EnterData("Enter column massive 2:");
int[,] array2 = new int[v, b];

FillArray(array2);
Console.WriteLine("Massive 2:");
PrintArray(array2);

int[,] result = MultiplyArray(array1, array2);
Console.WriteLine("Massive multipication is:");
PrintArray(result);
