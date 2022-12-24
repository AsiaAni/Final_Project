string[] array = new string[] { "hello", "2", "world", ":-)" };
Console.Write(array[0]);
Console.Write(" ");
Console.Write(array[1]);
Console.Write(" ");
Console.Write(array[2]);
Console.Write(" ");
Console.Write(array[3]);
Console.WriteLine();
string[] array2 = new string[array.Length];
string[] Method1(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
            arr2[i] = arr1[i];
    }
    return arr2;
}

void Method2(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] != null)
        {
            Console.Write($"{arr[i]} ");
        }
}
Method2(Method1(array, array2));


