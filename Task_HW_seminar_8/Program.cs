// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Task54();

void Task54()
{
    
    int [,] massiv = InitMassiv();
    Console.WriteLine();
    FillMassivRandom(massiv);
    PrintMassivRandom(massiv);
    Console.WriteLine();
    Console.WriteLine("Sort out massiv ");
    ChangeElementMassiv(massiv);
    PrintMassivRandom(massiv);
}

int[,] InitMassiv()
{
    Console.WriteLine("Enter of rows: ");
    int rows = int.Parse(Console.ReadLine());
     Console.WriteLine("Enter of columns: ");
    int columns = int.Parse(Console.ReadLine());
    
    return new int [rows,columns];
}

void PrintMassivRandom(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMassivRandom(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            int numbers = new Random().Next(byte.MinValue,byte.MaxValue);
            massiv[i,j] = numbers;
        }
    }
}

void ChangeElementMassiv(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {      
            for (int a = 0; a < massiv.GetLength(1) - 1; a++)
            {
                if (massiv[i,a] < massiv[i,a+1])
                {
                int max = massiv[i, a+1];
                massiv[i, a+1] = massiv[i,a];
                massiv[i,a] = max;
                }
            }
         }    
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Task56();

void Task56()
{
    int [,] massiv = SetSazeMassiv();
    if (massiv.GetLength(0) == massiv.GetLength(1))
    {
        Console.WriteLine("The strings don't have to be equal. Try again.");
    }
    else
    {
        Console.WriteLine();
        FillArray(massiv);
        PrintArray(massiv);
        Console.WriteLine();
        MinSummLine(massiv);
        FillMinSummRow(massiv);
    }

}

int [,] SetSazeMassiv()
{
    Console.WriteLine("Write first line: ");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Write second line: ");
    int second = int.Parse(Console.ReadLine());
    return new int [first, second];
    
}

void FillArray(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            int numbers = new Random().Next(byte.MinValue,byte.MaxValue);
            massiv[i,j] = numbers;
        }
    }
}

void PrintArray(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]}  ");
        }
        Console.WriteLine();
    }
    
}

void MinSummLine(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int newIndex = 0;
        int sumElements = 0;
        for (int j = 0; j < massiv.GetLength(1) ; j++)
        {
            sumElements += massiv[i,j];
        }
        newIndex = i;
        Console.WriteLine($"\nin row {newIndex} summa elements = {sumElements}");
    }
    Console.WriteLine();
}

void FillMinSummRow(int [,] massiv)
{
    int [] num = new int[massiv.GetLength(0)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            num[i] += massiv[i,j];
        }   
    }
    int minIndex = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        if (num[minIndex] > num[i])
        {
            minIndex = i;
        }
    }
    Console.WriteLine($"\nin row {minIndex}  min summa elements = {num[minIndex]}");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

Task58();

void Task58()
{
    int [,] firstMatrix = WriteFirstMatrix();
    int [,] secondMatrix = WriteSecondMatrix();
    Console.WriteLine();
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("False, the number of rows and columns must match");
    }
    else
    {
        FillFirstMatrix(firstMatrix);
        PrintFirstMatrix(firstMatrix);
        Console.WriteLine();
        FillSecondMatrix(secondMatrix);
        PrintSecondMatrix(secondMatrix);
        Console.WriteLine();
        int [,] matrix = MultiplyMatrix(firstMatrix,secondMatrix);
        PrintNewMatrix(matrix);
    }

}

int [,] WriteFirstMatrix()
{
    Console.WriteLine("write first size: ");
    int firstLine1 = int.Parse(Console.ReadLine());
    Console.WriteLine("write second size: ");
    int secondLine1 = int.Parse(Console.ReadLine());
    return new int [firstLine1, secondLine1];
}

int [,] WriteSecondMatrix()
{
    Console.WriteLine("write first size: ");
    int firstLine2 = int.Parse(Console.ReadLine());
    Console.WriteLine("write second size: ");
    int secondLine2 = int.Parse(Console.ReadLine());
    return new int [firstLine2, secondLine2];
}

void FillFirstMatrix(int [,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            int number = new Random().Next(1,10);
            firstMatrix [i,j] = number;
        }
    }
}

void PrintFirstMatrix(int [,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($"{firstMatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillSecondMatrix(int [,] secondMatrix)
{
    for (int k = 0; k < secondMatrix.GetLength(0); k++)
    {
        for (int t = 0; t < secondMatrix.GetLength(1); t++)
        {
            int number = new Random().Next(1,10);
            secondMatrix [k,t] = number;
        }
    }
}

void PrintSecondMatrix(int [,] secondMatrix)
{
    for (int k = 0; k < secondMatrix.GetLength(0); k++)
    {
        for (int t = 0; t < secondMatrix.GetLength(1); t++)
        {
            Console.Write($"{secondMatrix[k,t]} ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplyMatrix(int [,] firstMatrix, int [,] secondMatrix)
{
    int [,] matrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int x = 0; x < firstMatrix.GetLength(1); x++)
            {
                matrix[i,j] += firstMatrix[i,x] * secondMatrix[x, j]; 
            }
        }
    }
    return matrix;
}

void PrintNewMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
