//Семинар 9 рекурсия

void ShowNums(int n)//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
{
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);      
    }
    Console.Write(n + " ");
}

int SumOfDigits(int n)//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
{
    if (n >= 10)
    {
        return n % 10 + SumOfDigits(n / 10);
    }
    else return n;
    
}

void Zadaha1(int m, int n) // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
{
    if (m < n)
    {
        // Console.Write(m + " ");
        Zadaha1(m + 1, n);      
    }
    
    Console.Write(m + " ");
}

int Zadacha2(int a, int b)// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
{
     Console.WriteLine(a);

    if (b > 1)
    {
        Console.Write(a);
        
        return a = a * Zadacha2(a , b - 1);
    }
    
    return a;
    
}


// ShowNums(5);
Console.WriteLine();
// Console.WriteLine(SumOfDigits(12345));
int m = 2;
int n = 4;
// Zadaha1(m, n);
// Console.WriteLine(n);

Console.WriteLine(Zadacha2(m, n));


