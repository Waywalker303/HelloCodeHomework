/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = Input("Введите число: ");
int count = 0;
int sum = 0;

while(number > 0)
    {
    sum += number % 10;
    number = number / 10;
    count++;
    }
Console.WriteLine(sum);


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}