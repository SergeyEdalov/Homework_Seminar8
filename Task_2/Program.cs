// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindSumStrings(int[,] matr, int[] arrSumStrings)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(0); k++)
        {
            int sum = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum += matr[i, j];
            }
            arrSumStrings[k] = sum;
            Console.Write(arrSumStrings[k] + " ");
            break;
        }
    }
    return arrSumStrings;
}

int FindMinStrings(int[] matr)
{
    int i = 0;
    int minCount = matr[i];
    int minPosition = i;
    for (i = 0; i < matr.Length; i++)
    {
        if (matr[i] < minCount)
        {
            minCount = matr[i];
            minPosition = i;
        }
    }
    Console.WriteLine($"String with smallest summ - {minPosition + 1} line");
    return minCount;
}


int m = EnterData("Enter rectangular massive dimension");
int[,] array = new int[m, m];

FillArray(array);
Console.WriteLine("Massive");
PrintArray(array);
Console.WriteLine("Summ Strings");

int[] arrSum = new int[m];
FindSumStrings(array, arrSum);
Console.WriteLine();
FindMinStrings(arrSum);









