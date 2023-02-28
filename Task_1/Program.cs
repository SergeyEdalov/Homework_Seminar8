// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            matr[i, j] = new Random().Next(0, 30);
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

int[,] OrderLines(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int minPosition = j;

            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, minPosition])
                {
                    minPosition = k;
                }
            }
            int temporary = matr[i,j];
            matr[i,j] = matr[i,minPosition];
            matr[i,minPosition] = temporary;
        }

    }
    return matr;
}




int m = EnterData("Enter string massive");
int n = EnterData("Enter column massive");
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine("Massive");
PrintArray(array);

OrderLines(array);
Console.WriteLine("Sort massive");
PrintArray(array);