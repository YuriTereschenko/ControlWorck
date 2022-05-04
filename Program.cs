string[] arrayOfStrings = { "Привет", "мир", "$)", "дом", "корабль", "морж" };

int length = NewArrayLength(arrayOfStrings);
string[] Decision = PickRelevantWords(length, arrayOfStrings);
PrintArray(arrayOfStrings, "Имеющийся массив");
PrintArray(Decision, "Новый массив");


int NewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}


string[] PickRelevantWords(int length, string[] array)
{
    string[] Result = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            Result[j] = array[i];
            j++;
        }
    }
    return Result;
}


void PrintArray(string[] array, string nameOfArray)
{
    System.Console.WriteLine(nameOfArray + ":");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine(array[array.Length - 1] + ".");
    System.Console.WriteLine("---------");
}