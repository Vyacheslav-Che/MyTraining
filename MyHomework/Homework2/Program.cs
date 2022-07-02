// Домашнее задание 2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void OutputSecondNum(int num)
{   
    int res; 
    if(num > 100 && num < 1000)
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

Console.Write("Введите трехзначное чиссло: ");
int num2 = Convert.ToInt32(Console.ReadLine());
OutputSecondNum(num2);

