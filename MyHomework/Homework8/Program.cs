//Homework 8

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

int[,] ArrangesTheElementsOfMmasiva(int[,] array2d)
{
    int minNum = 0;
    
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {   
           for (int a = j; a < array2d.GetLength(1); a++)
           {    
                minNum = array2d[i,j];

                if (minNum  > array2d[i,a])
                {
                    minNum = array2d[i,a];
                    array2d[i,a] = array2d[i,j];
                    array2d[i,j] = minNum;
                    
                }

           }
            
        
        }

    }

    return array2d;
}

void OutputsRowSmallestAmount(int[,] array2d)
{   
    int sum = 0;
    int min = 0;
    int a  = 1;

    
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {   
           
            sum = array2d[i,j] + sum;
            if(i == 0)
            {
                min = sum;
            }
           
        }

        if(min > sum)
        {
            min = sum;
           
            a = i + 1;
        }
        Console.Write(sum + " | ");
        sum = 0;
    }

    Console.WriteLine("Наименьшая сумма элементов в строке: " + a);
}

void CreatesASpiralArray(int rows, int columns)
{
    int[,] new2dArray = new int[rows, columns];
    int temp = 1;
    int a = 0;
    int c = 0;

    while(temp <= rows * columns)
    {
        new2dArray[a,c] = temp;
        temp++;
        if (a <= c + 1 && a + c < columns - 1)
        c++;
        else if (a < c && a + c >= rows - 1)
        a++;
        else if (a >= c && a + c > columns - 1)
        c--;
        else
        a--;
    }
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (new2dArray[i,j] / 10 <= 0)
            Console.Write(new2dArray[i,j] + " ");
            else 
            Console.Write(new2dArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}
    
    
// Console.Write("Вводимое количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Вводимое количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввод минимально возможного значения: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввод максимально возможного значения: ");
// int max = Convert.ToInt32(Console.ReadLine());




//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] myArray = CreateRandom2dArrayInt(m, n, min, max);
// Show2dArray(myArray);
// ArrangesTheElementsOfMmasiva(myArray);
// Show2dArray(ArrangesTheElementsOfMmasiva(myArray));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] myArray = CreateRandom2dArrayInt(m, n, min, max);
// Show2dArray(myArray);
// OutputsRowSmallestAmount(myArray);

// Задача 62. Заполните спирально массив 4 на 4.
CreatesASpiralArray(4, 4);

