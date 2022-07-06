// Семинар 4

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int a)
{
    int sum = 0;

    for(int current =1; current <= a; current++)
       sum += current; // sum = sum + current; 

    return sum;    
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from i to {num} is {FindSum(num)}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Proisvedeni(int n)
{
    int res = 1;
    int a = 1;

    for (int i = 2; i < n; i++)
    {
        res = res * i;
        
    }

    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proisvedeni(num));
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Colvo(int num)
{
    int res = 1;
    int a = num; 

    while (a > 10)
    {
        a = a / 10;
        res++; 
    }
  

    return res;
}

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Colvo(num2));



//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void zadacha3(int a, int b)
{
    int c = a;

    for (int i = 1; i < b; i++)
    {
        c = c * a; 
    }

    Console.WriteLine(c);

}

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
zadacha3(num2, num3);
*/