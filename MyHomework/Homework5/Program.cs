

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; // инициализирует массив

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}


int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
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

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// void NumberOfEven(int[] array)
// {
//     string res = String.Empty;
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 99 && array[i] < 999 && array[i] > -1)
//         {
//              if(array[i] % 2 == 0)
//                 count++;
//                 res = "Количество чётных цифр в массиве: " + count.ToString();
            
//         }
//         else
//         {
//             i = array.Length;
//             res = "Неверно заданы данные!";
//         }

//     }
    
//     Console.WriteLine(res);
// }


// Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами.");
// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте максимальное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] numArray;
// numArray = CreateRandomArray(size, minValue, maxValue);
// NumberOfEven(numArray);

// ShowArray(numArray);





//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOfNonEvenPositions(int[] array)
// {
//     int res = 0;

//     for (int i = 1; i < array.Length; i++)
//     {
//         res = res + array[i];
//         i++;
//     }

//     return res;
// }

// int[] array = CreateRandomArray(4, 1, 20);
// ShowArray(array);
// Console.Write("Сумма элементов, стоящих на нечётных позициях: " + SumOfNonEvenPositions(array));




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }

    Console.WriteLine();
}

double[] CreateRandomArrayDouble(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    double a = 0;

    for(int i = 0; i < size; i++)
    {  
        a = new Random().NextDouble();
        a = Math.Round(a, 1);
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        newArray[i] = newArray[i] + a;
    }

    return newArray;
}

double ArrayRealNumbers(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    double res = 0;

    for(int i = 1; i < array.Length; i++)
    {   
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
        if (minNum > array[i])
        {
            minNum = array[i];
        }

    }

    res = maxNum - minNum;
  
    return res;
}

double[] arrayReal = CreateRandomArrayDouble(10, -10, 10);
ShowArrayDouble(arrayReal);
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + ArrayRealNumbers(arrayReal));




