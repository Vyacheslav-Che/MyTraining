// вид 1. Ничего не возвращает и ничего не принемает.
/*
void Method1()
{
    Console.WriteLine("автор...");
}

Method1(); // Вызов метода. 



// Вид 2. Это методы которые ничего не возвращают но могут ппринемать какието аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); //вызов метода

//Вызов именованных аргументов 

void Method2v1(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2v1(msg: "Текст сообщения", count: 4); //вызов именованных аргументов (необязательно по порядку)


// Вид 3. Что то возврощают но ниччего не принемают. 

int Method3()
{
    return DateTime.Now.Yer; // обязательно return для возвращения
}

int year = Method3();
Console.WriteLine(year);


// Вид 4. Что то  принемают и чтото возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf"); 
Console.WriteLine(res);
*/
/*
string Method4(int count, string text)
{

    string result = String.Empty; // пустая строка
    for(int i = 0; i < count; i++) // цикл со счетчиком 
    {
        result = result + text;
       
    }
    return result;
}

string res = Method4(10, "z"); 
Console.WriteLine(res);
*/

//Цыклы в цыкле. 
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // ($"{i} x {j} = {i * j}") интропаляция строк
    }
    Console.WriteLine();
}
*/

/*
string text = "- Я думаю, - сказал князь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречиво. Вы дадите мне чаю?";

// для того что бы получить конкретный символ мы можем обратиться s[2];

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length; //text.Length; выводит длину строки.
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return  result; 
}

string newTrxt = Replace(text, ' ', '|');
 Console.WriteLine(newTrxt);
 Console.WriteLine();
 newTrxt = Replace(text, 'к', 'К');
Console.WriteLine(newTrxt);
*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
