/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] arrayRandom = new int[13];

ArrayRandom(arrayRandom);
ArrayMaxMin(arrayRandom);   

void ArrayMaxMin(int[] arrayRandom)
{
int max = arrayRandom[0];
int min = arrayRandom[0];
for(int i = 0; i < arrayRandom.Length; i++)
{
     if(arrayRandom[i] < min )
        {
        min = arrayRandom[i];
        }
             if(arrayRandom[i] > max )
            {
            max = arrayRandom[i];
            }
    }
Console.WriteLine($"Разница между максимальным и минимальным: {max}-{min}={max-min}");
}

void ArrayRandom(int[] arrayRandom)
{
    int length = arrayRandom.Length;
    int i = 0;
    while (i < length)
    {
        arrayRandom[i] = new Random().Next(0, 100);
        Console.Write(arrayRandom[i] + " ");
        i++;
    }
    Console.WriteLine();
}