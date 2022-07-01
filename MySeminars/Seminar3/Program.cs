//Семинар 3
/*
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
        Console.WriteLine("This number is uncorrect!");
}

Console.Write("Input number of quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
*/
 
 //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ShowQuart(int x, int y)
{
    int result = -1; 

    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;

    return result;
}

Console.WriteLine("Ведите координату x: ");
int u = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату y: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowQuart(u, p));



 