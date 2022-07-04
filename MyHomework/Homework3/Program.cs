// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void ChecPalindrom(int num)
{
   int a = num;
   int b = 0;
   int c = 0; 

   while (num > 0)
   {
        c = num % 10;
        b = b * 10 + c; 
        num = num / 10;
   }

    if(a == b)
    {
        Console.Write("Число являеться палиндромом");
    }
    else
    {
        Console.Write("Число не являеться палиндромом");
    }

   
}

Console.Write("Введите пятизначное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ChecPalindrom(num2);

