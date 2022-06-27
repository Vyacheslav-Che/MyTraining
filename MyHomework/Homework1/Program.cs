//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

