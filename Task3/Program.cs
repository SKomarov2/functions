void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
//foreach -- не меняет значения переменой 
//while -- не знаем точное число итераций 
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");

    }
}
int[] array = { 10, 22, 44, 66, 77 };
ZeroEvenElements(array);
PrintArray(array);
