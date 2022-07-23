//Homework 9

// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

// int FindsTheNumberOfDigits(int n)
// {   
//     if(n / 10 != 0)
//     {
//         return n = 1 + FindsTheNumberOfDigits(n/10);
//     }
//     else
//     {
//         return n;
//     }

// }

// Console.WriteLine(FindsTheNumberOfDigits(12));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfElements(int m, int n)
{
    if(m < n)
    {
        return m = m + SumOfElements(m + 1, n);
    }
    else
    {
        return m;
    }
}

Console.WriteLine(SumOfElements(4,8));