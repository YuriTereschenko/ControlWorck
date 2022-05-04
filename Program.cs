//Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа.

string[] arrayOfStrings = { "Привет", "мир", "$)", "дом", "корабль", "морж" };
System.Console.WriteLine(NewArrayLength(arrayOfStrings));

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