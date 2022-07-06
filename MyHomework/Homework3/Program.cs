// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
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
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void OutputsTableCubes(int n)
{
    int i = 1;
    int a = 1;

    while (n >= i)
    {
        a = a * a * a; 
        i++;
        Console.Write(a + " ");
        a = i;
        
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
OutputsTableCubes(num);
