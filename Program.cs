// Задача 47
// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, double minValue, double maxValue)
{ 
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]:F1}  ");                   
        }
        Console.WriteLine();
    }
}
*/

// Задача 50
// Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
// и возвращает значение этого элемента либо указание, что такого элемента нет
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SearchElement(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] Array)
{
    Console.WriteLine("Введите номер строки: ");
    int num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца: ");
    int num2 = int.Parse(Console.ReadLine()!);
    if (num1 <= Array.GetLength(0)-1 && num2 <= Array.GetLength(1)-1)
    Console.Write($"Элемент массива на этой позиции равен {Array[num1,num2]}  "); 
    else 
    Console.WriteLine($"В массиве нет элемента с ндексами {(num1, num2)}");            
}
*/

// Задача 52
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ArithmeticMeanColumns (array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumns (int[,] Array)
{
    for (int j = 0; j < Array.GetLength(1); j++ )
    {        
        double result = 0;
        double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum = sum + array[i,j];                              
        }  
    result = sum / Array.GetLength(1);  
    Console.WriteLine($"Среднее арифметическое столбца {j}:  {result:F1}");    
    }        
}
*/

// Задачи на трехмерные массивы разберу на каникулах решу в следующем ДЗ. 