// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"Hello", "2", "world", ",)"};
int total = 0;

void LengthNewArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            total++;
        }
    }
}

string[] InputDateNewArray(string[] array)
{
    string[] newArray = new string[total];
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {        
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintNewArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        Console.WriteLine("[\"" + (String.Join("\", \"", array)) + "\"]");
    }
}

LengthNewArray(array);
PrintNewArray(InputDateNewArray(array));

