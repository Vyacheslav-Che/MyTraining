// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];

//     Console.WriteLine("Creating array here: ");

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i + 1} element: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());

//     }
//     Console.WriteLine();
//     return newArray;
// }

string[] CreateArray(int size)
{
    string[] newArray = new string[size];

    Console.WriteLine("Создание массива здесь: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Ввод {i + 1} строки: ");
        newArray[i] = Convert.ToString(Console.ReadLine());

    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }

    Console.WriteLine();
}

string[] CreatesArrayOfThreeCharacters(string[] arrayString)
{
    int size = 0;
    string[] newArray = new string[size];
    
    for (int i = 0; i < arrayString.Length; i++)
    {   
        if (arrayString[i].Length < 3 || arrayString[i].Length == 3)
        {   
            Array.Resize(ref newArray, size + 1);
            newArray[size] = arrayString[i];
            size++; 
        }
    }
    
    if (newArray.Length == 0)
    {
        Array.Resize(ref newArray, 1);
        newArray[0] = "Все строки больше 3 символов";
    }

    return newArray;
}

Console.Write("Входной размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] strihgArray = CreateArray(size);
ShowArray(CreatesArrayOfThreeCharacters(strihgArray));
