/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] arrayRandom = new int[13];

ArrayRandom(arrayRandom);
Console.Write("Сумма нечётных чисел в заданном массиве = ");
ArraySumEven(arrayRandom);   // ?как вывести функцию и текст ?при смене имени "arrayRandom" вылетает ошибка об несуществовании имени, замена в методе не помогает


void ArraySumEven(int[] arrayRandom)
{
int sum = 0;
for(int i = 0; i < arrayRandom.Length; i++)
{
     if(arrayRandom[i] % 2 != 0 )
        {
        sum = arrayRandom[i] + sum;
        }
    }
Console.WriteLine(sum);
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