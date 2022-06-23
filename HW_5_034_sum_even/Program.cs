/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] arrayRandom = new int[13];

ArrayRandom(arrayRandom);
Console.Write("Колличество чётных чисел в заданном массиве = ");
ArrayCountEven(arrayRandom); // ?как вывести функцию и текст ?при смене имени "arrayRandom" вылетает ошибка об несуществовании имени, замена в методе не помогает

void ArrayCountEven(int[] arrayRandom)
{
int count = 0;
for(int i = 0; i < arrayRandom.Length; i++)
{
     if(arrayRandom[i] % 2 == 0 )
        {
        count++;
        }
}
Console.WriteLine(count);
}

void ArrayRandom(int[] arrayRandom)
{
    int length = arrayRandom.Length;
    int i = 0;
    while (i < length)
    {
        arrayRandom[i] = new Random().Next(99, 1000);
        Console.Write(arrayRandom[i] + " ");
        i++;
    }
    Console.WriteLine();
}