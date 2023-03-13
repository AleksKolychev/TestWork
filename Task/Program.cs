/* Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма.

["hola", "2", "world", "!", ";)"] */

void FillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

Console.Clear();
string[] array1 = new string[] {"hola", "2", "world", "!!!", ";)"};
Console.WriteLine($"{string.Join(" ", array1)}");
string[] array2 = new string[array1.Length];
FillSecondArray(array1, array2);
Console.Write($"{string.Join(" ", array2)}");