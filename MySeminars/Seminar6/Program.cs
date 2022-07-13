// Семинар 6

//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] RevwrseArray(int[] array)
// {   
    
//     for (int i = 0, j = array.Length - 1; i < j / 2; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }

//     // int i = 0, j = array.Length - 1;

//     // while (i < j)
//     // {
//     //     int temp = array[i];
//     //     array[i] = array[j];
//     //     array[j] = temp;

//     //     i++;
//     //     j--;
//     // }

//     return array;
// }

// int[] maArray = {3, 5, 1, 8, 2, 9, 4};
// maArray = RevwrseArray(maArray);

// for(int i = 0; i < maArray.Length; i++)
//     Console.Write(maArray[i] + " ");

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 18 / 2 -> 9 8
// 9 / 2 -> 4 1
// 4 / 2 -> 2 0 
// 2 / 2 -> 1 0
// 1 / 2 -> 0 1

// 18 -> 10010

// string ChengeDigitSystem(int num)
// {
//     string resulNumber = string.Empty;

//     while (num > 0)
//     {
//         resulNumber = num % 2 + resulNumber;
//         num /= 2; // тоже самое что num = nun / 2;
//     }

//     return resulNumber;
// }

// Console.WriteLine(ChengeDigitSystem(18));

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// void zadacha1(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && c + b > a)
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }
// }

// Console.WriteLine("Введиде стороны треугольника: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// int b2 = Convert.ToInt32(Console.ReadLine());
// int c2 = Convert.ToInt32(Console.ReadLine());
// zadacha1(a2, b2, c2);



//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. вывести масив

//ряд фибоначи 0 1 1 2 3 5 8 13 21 34 смысл в том что бы сложить число с предыдущим 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }

    Console.WriteLine();
}

// int[] Zadacha2(int a, int b, int size)
// {
//     int[] resArray = new int[size];
//     resArray[0] = a;
//     resArray[1] = b;
//     int res;


//     for (int i = 2; i < size; i++)
//     {
//         res = a + b;
//         a = b;
//         b  = res;
//         resArray[i] = res;
//     }
//     return resArray;
// }

// Console.WriteLine("Введиде первые два числа фибоначи: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// int b2 = Convert.ToInt32(Console.ReadLine());
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(Zadacha2(a2, b2, size));


bool zadacha1(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
    // if (a + b > c && a + c > b && c + b > a) return true;
    // else return false;
    
}

Console.WriteLine("Введиде стороны треугольника: ");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int c2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(zadacha1(a2, b2, c2));






