// Семинар 5

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.

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
        Console.Write(array[i] + " ")

    }

    Console.WriteLine();
}

/*
int FindPositiveSum(int[] array)
{
    int sum =0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }

    return sum; 
}
*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] zadacha1(int[] array)
{
   int[] resArr = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        resArr[i] = array[i] * -1;
    }

    return resArr;
}
*/

// Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void zadacha2(int[] array, int min, int max)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i >= min && i < max)
        {
            
            sum = sum + 1; 
        }
    }
    Console.WriteLine(sum);
    
}


Console.Write("Входной размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод минимально возможного значения элементов: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элементов: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array1 = CreateRandomArray(size, min, max);
//int[] array2 = CreateArray(size);

ShowArray(array1);

Console.Write("Введите минемальное число отрезка: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число отрезка: ");
int max2 = Convert.ToInt32(Console.ReadLine());

zadacha2(array1, min2, max2);

//ShowArray(array2);
//int sumOfPositive = FindPositiveSum(array1);
//Console.WriteLine("Sum of positive elements is current array is " + sumOfPositive);

//int [] a = zadacha1(array1);
//Console.WriteLine("вывод" + a);







