// Написать программу замену элементов массива на противоположные
//

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void RevertArray(int[] arr)
{
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = -arr[i];
        }
}

int[] array = new int[8];
FillArray(array);
Console.Write("Массив до: ");
PrintArray(array);
Console.WriteLine("");
RevertArray(array);
Console.Write("Массив после: ");
PrintArray(array);
