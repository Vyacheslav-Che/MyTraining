﻿// Домашнее задание 2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void OutputSecondNum(int num)
{   
    int res; 
    if(num > 100 && num < 1000)
    {
        res =  num / 10;
        res = res % 10; 
        Console.WriteLine("Вторая цифра числа " + res);
    }
    if(num < -100 && num > -1000)
    {
        res =  num / 10;
        res = res % 10; 
        Console.WriteLine("Вторая цифра числа " + res);
    }
    else
    {
         Console.WriteLine("Не верное число");
    }

}

Console.Write("Введите трехзначное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
OutputSecondNum(num2);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
string OutputThirdNum(int num)
{
    string result = "Третьей цифры нет"; 

    if(num > 99 )
    {  
        while (num > 999)
        {
            num = num / 10;
        }

        result = Convert.ToString(num % 10);
       
    }
    else
    {
        if(num < -99)
        {
            while (num < -999)
            {
                num = num / 10;
            }

            result = Convert.ToString(num % 10);
        }
        
    }
  
    return result; 

}

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(OutputThirdNum(num2));
*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckingDay(int numDay)
{
    while(numDay > 7)
    {
        numDay = numDay - 7;
    }

    if(numDay == 6 || numDay == 7)
    {
        Console.Write("Этод день выходной");
    }
    else
    {
        Console.Write("Этод день не выходной");
    }
}

Console.Write("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
CheckingDay(num);




