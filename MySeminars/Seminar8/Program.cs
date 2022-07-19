// seminar 8


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] Revers2dArray(int[,] array)
{   
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Numbers of rows and columns is not the same!");
        return array;
    }
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }

    return array;
}

//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] Cut2dArray(int[,] array)
{
    int iMin = 0; int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[iMin, j] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i,jMin] = 0;
    }

    return array;
}

//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] zadacha(int[,] array)
{   
    // int[,] newArray = new int(array.GetLength(0), array.GetLength(1));

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[array.GetLength(1)-1,i];
        array[array.GetLength(1)-1,i] = array[0,i];
        array[0, i] = temp;

    }
    return array;
}

Console.Write("Вводимое количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Входной номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод минимально возможного значения: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод максимально возможного значения: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Show2dArray(zadacha(myArray));