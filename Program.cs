// Задача: Написать программу, 
// которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = new string[number];
FillArray(array);

Console.WriteLine();
Console.WriteLine("Ваш массив: ");
PrintArray(array);

Console.WriteLine();
int elemLengthCount = ElemLengthCount(array);
Console.WriteLine($"Длинна нового массива -> {elemLengthCount}");

Console.WriteLine();
string[] selectShortElem = SelectShortElem(array);
Console.WriteLine("Новый массив: ");
PrintArray(selectShortElem);

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й номер элемента массива");
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int ElemLengthCount(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] SelectShortElem(string[] arr)
{
    int j = 0;
    string[] arr2 = new string[elemLengthCount];
    for (int i = 0; i < arr.Length;)
    {
        if (arr[i].Length <= 3)
        {
            arr2[j] = arr[i];
            j++;
            i++;
        }
        else i++;
    }
    return arr2;
}

