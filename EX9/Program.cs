int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void Selec(int[] array)
{
     for(int i = 0; i < array.Length - 1; i++)
     {
        int Pos = 1;

        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[Pos]) Pos = j;
        }
        //
        //
        //
        int temparray = array[i];
        array[i] = array[Pos];
        array[Pos] = temparray;
     }
}

PrintArray(arr);
Selec(arr);


PrintArray(arr);
