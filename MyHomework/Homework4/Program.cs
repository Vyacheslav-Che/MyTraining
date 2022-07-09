//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumbers(int num)
// {
//     int res = 0;
//     {
//         while (num > 0)
//         {
//             res = res + num % 10;
//             num = num / 10;
//         }
//     }

//     return res;
// }

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма цифр в числе: {SumNumbers(num2)}");


//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

void array(int size)
{
    int[] newArray = new int[size];


    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());

    }

    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");

    }


}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
array(size);