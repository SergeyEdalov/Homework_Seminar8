// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FillSpirallyArray(int[,] matr)
{
    int num = 1; int i = 0; int j = 0;
    while (num <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return num;
}

int[,] PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] / 10 <=0) Console.Write($"0{matr[i, j]}   ");
            else Console.Write($"{matr[i, j]}   ");
        }
        Console.WriteLine();
    }
    return matr;
}


int m = EnterData("Enter rectangular massive dimension");

int[,] array = new int[m, m];

FillSpirallyArray(array);
PrintArray(array);