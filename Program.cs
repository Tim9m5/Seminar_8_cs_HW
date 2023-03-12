// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int rows = 5;
int cols = 6;

int[,] resultMatrix = GetMatrix(rows, cols, 0, 10);

PrintMatrix(resultMatrix);

Console.WriteLine("Результат: ");
PrintMatrix(GetMatr(resultMatrix));

int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMatr(int[,] resultMatrix)
{
    int[,] copyMatrix = new int[resultMatrix.GetLength(0), resultMatrix.GetLength(1)];
    for (int i = 0; i < copyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < copyMatrix.GetLength(1); j++)
        {
            int maxRow = 0;
            int maxI = i;
            int maxJ = j;
            for (int k = j; k < copyMatrix.GetLength(1); k++)
            {
                if (resultMatrix[i, k] > maxRow)
                {
                    maxRow = resultMatrix[i, k];
                    maxI = i;
                    maxJ = k;
                }
            }
            copyMatrix[i, j] = resultMatrix[maxI, maxJ];
            resultMatrix[maxI, maxJ] = resultMatrix[i, j];
        }
    }
    return copyMatrix;
}
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int rows = 5;
int cols = 5;

int[,] resultMatrix = GetMatrix(rows, cols, 0, 10);

PrintMatrix(resultMatrix);

Console.WriteLine("Результат: ");

int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] result = new int[rows]; 
// массив в который в качестве элементов попадут суммы строк

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    
    int temp = 0;
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        temp = temp + resultMatrix[i, j];
        result[i] = temp;
    }
    Console.WriteLine($"Сумма строки {i + 1} равна: {temp}");
    
}

int min = int.MaxValue;
int indexMin = 0;
for(int m = 0; m < rows; m++) // ищем элемент массива result с минимальным значением
{
    if(result[m] < min)
    {
        min = result[m];
        indexMin = m+1; 
        // индекс элемента с минимальным значением +1 дает нам номер искомой строки
    }
}
Console.WriteLine($"Минимальная сумма элементов в строке № {indexMin}");
*/

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
/*
int rows = 3;
int cols = 3;
// Матрица 1
Console.WriteLine("Матрица 1: ");

int[,] resultMatrix1 = GetMatrix1(rows, cols, 0, 10);

PrintMatrix1(resultMatrix1);



int[,] GetMatrix1(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix1(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Матрица 2
Console.WriteLine("Матрица 2: ");

int[,] resultMatrix2 = GetMatrix2(rows, cols, 0, 10);

PrintMatrix2(resultMatrix2);



int[,] GetMatrix2(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix2(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Результирующая матрица
Console.WriteLine("Результат: ");

int[,] resultMatrix3 = GetMatrix3(rows, cols, 0, 10);

PrintMatrix3(resultMatrix3);



int[,] GetMatrix3(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = resultMatrix1[i,j] * resultMatrix2[i,j];
        }
    }
    return matrix;
}

void PrintMatrix3(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int rows = 2;
int cols = 2;
int dep = 2;

int[,,] resultMatrix = CreateMatrix(rows, cols, dep, 0, 10);

PrintMatrix(resultMatrix);

Console.WriteLine("Результат: ");

int[,,] CreateMatrix(int rows, int cols, int dep, int min, int max)
{
    int[,,] matrix = new int[rows, cols, dep];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                matrix[i, j, k] = new Random().Next(min, max + 1);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(1); k++)
            {
                Console.Write($"{inputMatrix[i, j, k]} ({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }

    }
}
*/