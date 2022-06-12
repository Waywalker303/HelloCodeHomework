/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа*/
Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string thirdDigit = number.ToString();
if((number.ToString().Length) > 3)
    {
    Console.WriteLine(thirdDigit[2]);
    }
else
    {
    Console.WriteLine("Ошибка! В числе нет третьей цифры!");
    } 