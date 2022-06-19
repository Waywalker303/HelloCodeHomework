/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] arrayRandom = new int[8];
int[] arr2 = {1, 2, 5, 7, 19};

ArrayRandom(arrayRandom);
Output(arr2);


void Output(int[]array)
{
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void ArrayRandom(int[] arrayRandom)
{
    int length = arrayRandom.Length;
    int i = 0;
    while (i < length)
    {
        arrayRandom[i] = new Random().Next(1, 10);
        Console.Write(arrayRandom[i] + " ");
        i++;
    }
    Console.WriteLine();
}