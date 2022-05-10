// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина 
// которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "2", "computer"] -> ["2"]
// ["Russia", "Germany", "Moscow"] -> []

string[] arrayInput = new string[] { "Russia", "Germany", "Moscow" };

string[] CreateValidArray(string[] array)
{
    int index = 0;
    int count = 0;
    int len = array.Length;
    while (index < len)
    {
        if (array[index].Length <= 3) count++;
        index++;
    }
    if (count == 0)
    {
        string[] validArray = new string[]{"нет валидных элементов!"};
        return validArray;
    }
    else
    {
        string[] validArray = new string[count];
        int validIndex = 0;
        index = 0;
        while (index < len)
        {
            if (array[index].Length <= 3) validArray[validIndex++] = array[index];
            index++;
        }
        return validArray;
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


PrintArray(arrayInput);
Console.WriteLine();
PrintArray(CreateValidArray(arrayInput));