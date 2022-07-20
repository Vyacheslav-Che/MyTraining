// домашняя работа 7

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }

        Console.WriteLine();
    }
}

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    double[,] newArrayDouble = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArrayDouble[i,j] = new Random().NextDouble();
            newArrayDouble[i, j] = Math.Round(newArrayDouble[i, j], 1);
            newArray[i ,j] = new Random().Next(minValue, maxValue + 1);
            newArrayDouble[i,j] = newArray[i, j] + newArrayDouble[i, j];
        }

    }

    return newArrayDouble;

}

int[,] CreateRandom2dArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i ,j] = new Random().Next(minValue, maxValue + 1);
        }

    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }

    Console.WriteLine();
}

double[] FindsArithmeticMeanEachColumn(int[,] array2d)
{   
    double[] newArray = new double[array2d.GetLength(1)];
    double temp = 0;

    for (int i = 0; i < array2d.GetLength(1); i++)
    {   
        for (int j = 0; j < array2d.GetLength(0); j++)
        {
            temp = temp + array2d[j,i];
        }
       
       newArray[i] = temp / array2d.GetLength(0);
       temp = 0;
    }
    return newArray;
}




Console.Write("Вводимое количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводимое количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод минимально возможного значения: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод максимально возможного значения: ");
int max = Convert.ToInt32(Console.ReadLine());

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] myAarray = CreateRandom2dArray(m, n, min, max);
// Show2dArrayDouble(myAarray);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] myAarray = CreateRandom2dArrayInt(m, n, min, max);
// Show2dArray(myAarray);
// ShowElement2dArray(myAarray);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] myAarray = CreateRandom2dArrayInt(m, n, min, max);
Show2dArray(myAarray);
Console.Write("Среднее арифметическое элементов в каждом столбце: ");
ShowArrayDouble(FindsArithmeticMeanEachColumn(myAarray));



