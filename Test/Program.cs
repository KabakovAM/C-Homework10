string [] CreateFillArrayString (int size)
{
    string [] array = new string [size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} эелемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string [] ShowElementSizeMin3(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}

Console.Write("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());
string[] arr = CreateFillArrayString (s);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Из массива убраны все элементы, длина которых больше трёх");
string [] result = ShowElementSizeMin3(arr);
PrintArray(result);