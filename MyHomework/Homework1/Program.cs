//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1;
int num2;

Console.WriteLine("Введи два числа. ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("число " + num1 + " больше числа " + num2);
}
if(num1 == num2)
{
    Console.WriteLine("число " + num1 + " число " + num2 + " равны");
}
else
{
    Console.WriteLine("число " + num1 + " меньше числа " + num2);
}
*/




//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int num1;
int num2;
int num3;
int max;

Console.WriteLine("Введи три числа. ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if(max > num3)
{
    Console.WriteLine("Максимальное число " + max);
}
else
{
    Console.WriteLine("Максимальное число " + num3);
}
