// семинар7
//Необходимо задать двумерный массив размером м н заполнить случайными цифрами

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i ,j] = new Random().Next(minValue, maxValue +1);
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
}

int FindDiagSum(int[,] array)
{
    int sum = 0;

    if(array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i,i];
    

    return sum;
}

int[,] Zadacha1(int rows, int columns)
{   
    int[,] newArray = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }

    return newArray;
}

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] Zadacha2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
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
// Console.WriteLine("Сумма главной диагонали равна " + FindDiagSum(myArray));

// int[,] myArray = Zadacha1(m, n);
// Show2dArray(myArray);
// Console.WriteLine("Сумма главной диагонали равна " + FindDiagSum(myArray));
Console.WriteLine(" ");
Show2dArray(Zadacha2(myArray));


























