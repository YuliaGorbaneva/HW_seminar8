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

Task56();

void Task56()
{
    int [,] massiv = SetSazeMassiv();
    SizeMAssiv(massiv);  
    Console.WriteLine();
    FillArray(massiv);
    PrintArray(massiv);
    Console.WriteLine();
    MinSummLine(massiv);
    FillMinSummRow(massiv);


}

int [,] SetSazeMassiv()
{
    Console.WriteLine("Write first line: ");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Write second line: ");
    int second = int.Parse(Console.ReadLine());
    return new int [first, second];
    
}

bool SizeMAssiv(int [,] massiv)
{
    if (massiv.GetLength(0) == massiv.GetLength(1))
    {
        Console.WriteLine("The strings don't have to be equal. Try again.");
    }
    return false;
}

void FillArray(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            int numbers = new Random().Next(1,10);//(byte.MinValue,byte.MaxValue);
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