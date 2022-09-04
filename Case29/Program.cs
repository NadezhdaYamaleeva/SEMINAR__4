// Задает массив из 8 элементов и выводит их на экран
void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index ++;
    }
}
void PrintArray(int[]coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos ++;
    }
    Console.Write(" ]");
}
int []array = new int[8];
FillArray(array);
PrintArray(array);
