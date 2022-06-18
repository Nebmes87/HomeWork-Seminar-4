// Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        System.Console.Write(r[i] + " ");
    }
    System.Console.WriteLine();
}

int[] RandomArray(int Length)
{
    int[] array;
    array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);

    }
    return array;
}

int[] MyArray = RandomArray(8);
PrintArray(MyArray);

// или без функций

int[] array2 = new int [8];
Random ran = new Random();
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = ran.Next(0, 1000);
    System.Console.Write(array2[i] +" ");
}