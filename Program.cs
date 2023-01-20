string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
int num = 3;
int j = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= num)
    {
        array2[j] = array1[i];
        j++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  {array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nНачальный массив строк: ");
PrintArray(array1);
Console.WriteLine("\nПолученный массив строк: ");
PrintArray(array2);