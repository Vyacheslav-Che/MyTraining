// Homework 6


int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Создание массива здесь: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Ввод {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    return newArray;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

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
}

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] SetDirect(int rows, int columns)
{
    double[,] new2dArray = new double[columns, rows];
    string[] stringsArray = new string[2];
    stringsArray[0] = "k"; 
    stringsArray[1] = "b"; 

    Console.WriteLine("Задать значение двух прямых здесь: ");

    for (int i = 0; i < rows; i++)
    {   
        Console.WriteLine($"Ввод значений {i + 1} прямой : y = k{i + 1} * x + b{i + 1} ");
        for (int j = 0; j < columns; j++)
        {
             Console.Write($" {stringsArray[j]}{i + 1}: ");
             new2dArray[i,j] = Convert.ToDouble(Console.ReadLine());
        }
        
    }

    return new2dArray;
}

double[] LineIntersections(double[,] array2d)
{   
    double[] array = new double[2];

   if(array2d[0,0] != array2d[1,1])
    {
        array[0] = (array2d[1,1] - array2d[0,1]) / (array2d[0,0] - array2d[1,0]);
        array[1] =  array[0] * array2d[0,0] + array2d[0,1];
    }

    return array;
}

void ChecksIntersection( double[] array, double[,] array2d)
{
    if (array2d[0,0] == array2d[1,0] && array2d[0,1] == array2d[1,1])
    {
        Console.WriteLine("Прямые совпадают точки пересечения нет");
    }
    else
    {
        if(array2d[0,0] == array2d[1,0] && array2d[0,1] != array2d[1,1])
        {
            Console.WriteLine("Прямые паралельны точки пересечения нет");
        }
        else
        {
            Console.Write("Значения точки пересечения двух прямых: ");
            ShowArrayDouble(array); 
        }
    }
}

double[,] array2d2 = SetDirect(2,2);
double[] array2 = LineIntersections(array2d2);
ChecksIntersection(array2, array2d2);


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int FindsQuantityGreaterZero(int[] array)
// {   
//     int res = 0;

//     for (int i = 0; i < array.Length; i++)
//         if(array[i] > 0) res++;

//     return res;
// }
// int arraySize = 5;
// Console.WriteLine("Введите " + arraySize + " элементов в массив.");
// int[] arrayNumbers = CreateArray(arraySize);

// ShowArray(arrayNumbers);

// Console.WriteLine("Чисел больше нуля = " + FindsQuantityGreaterZero(arrayNumbers));













    


    