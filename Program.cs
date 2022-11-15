Console.Clear();
Console.WriteLine("Введите длину массива...");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите допустимую длину для фильтрации");
int cut = Convert.ToInt32(Console.ReadLine());
string[] original = new string[size];
FillArray(original);
Console.WriteLine();
Console.WriteLine("Оригинальный массив...");
PrintArray(original);
Console.WriteLine();
Console.WriteLine("Длина массива = " + size);
Console.WriteLine("Значения будут отфильтрованы по длине " + cut);
if (SizeFiltArray(original) == 0)
{
    Console.WriteLine("Нет подходящих элементов в массиве");
}
else
{   
    Console.WriteLine();
    string[] filtered = FiltFillArray(original);
    Console.WriteLine("Отфильтрованный массив...");
    PrintArray(filtered);
}

void FillArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение...осталось значений" + " " + (size - i));
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SizeFiltArray(string[] array)
{   
    int filtSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i].Length <= cut)
        {
            filtSize++;
        }
    }
    return filtSize;
}
string[] FiltFillArray(string[] array)
{
    string[] filtered = new string[SizeFiltArray(original)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(array[i].Length <= cut)
        {
            filtered[j] = array[i];
            j++;
        }
    }
    return filtered;
}
