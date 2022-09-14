// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArray()
{

    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for (int i = 0; i < size; i++)

    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();

    }

    return array;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] SortArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}



Console.Clear();
string[] myArray = CreateArray();
Console.Write("Введенный массив: ");
PrintArray(myArray);
Console.Write("Новый массив: ");
string[] array2 = SortArray(myArray);
PrintArray(array2);
