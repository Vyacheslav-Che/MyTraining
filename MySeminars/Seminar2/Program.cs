
/*
int CutNumber()   
{
    int num = new Random().Next(100,1000); 
    Console.WriteLine("Current random nuber is " + num);

    int sotni = num / 100; 
    int ed = num % 10;

    int result = sotni * 10 + ed; 
    return result;

}

void CutNumberVoid()   
{
    int num = new Random().Next(100,1000); 
    Console.WriteLine("Current random nuber is " + num);

    int sotni = num / 100; 
    int ed = num % 10;

    int result = sotni * 10 + ed; 
    
    Console.WriteLine("Result number is " + result);
}

CutNumberVoid();
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
void RanNumberMax()
{
    int num = new Random().Next(10,99); 

    Console.WriteLine("Случайное число " + num);

    int desytki = num / 10; 
    int ed = num % 10;
    
    int result; 

    if(desytki > ed)
    {
        result = desytki;
    }
    else
    {
        result = ed;
    }
    
    
    Console.WriteLine("Наибольшее число " + result);

}

RanNumberMax();
*/ 

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
bool NNumber(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}


Console.WriteLine("Введите число ");
int num2 = Convert.ToInt32(Console.ReadLine());
NNumber(num2);
*/
//Console.WriteLine("Наибольшее число " + NNumber());





//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void IsQuad(int num1, int num2)
{
    int quad2 = num2 * num2;
    int quad1 = num1 * num1;

    if(num1 == quad2)
        Console.WriteLine("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");    
       

}