/*Задача: Написать программу, которая из имеющегося 
массива строк формирует новый массив из строк, длина
которых меньше, либо равна 3 символам. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



void FillArray(string?[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        array[i] = Console.ReadLine();
    }
}


void PrintArray(string[] array)
{
    int arrLenght = array.Length;
    System.Console.Write("[ ");
    for (int i = 0; i < arrLenght; i++)
    {
        Console.Write("'" + array[i] + "' ");
    }
    System.Console.Write("]");
}



int length = InputNumberWithMessage("Введите количество элементов массива: ");
string[] nunbers = new string[length];


FillArray(nunbers);
System.Console.WriteLine();
System.Console.WriteLine("Исходный массив:");
PrintArray(nunbers);


int n = 0;
for (int i = 0; i < nunbers.Length; i++)
{
    if (nunbers[i].Length <= 3)
        n++;
}

if (n == 0)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Элементов, длина которых меньше 3, не найдено ");
}

else
{
    System.Console.WriteLine();
    System.Console.Write($" Количество элементов, длина которых меньше или равна 3:  {n}");

    string[] resultArray = new string[n];

    int j = 0;
    for (int i = 0; i < nunbers.Length; i++)
    {
        if (nunbers[i].Length <= 3)
        {
            resultArray[j] = nunbers[i];
            j++;
        }
    }

    System.Console.WriteLine();
    System.Console.WriteLine("Полученный массив:");
    PrintArray(resultArray);
}









