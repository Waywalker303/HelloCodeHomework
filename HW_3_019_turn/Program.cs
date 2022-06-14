/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/
Console.WriteLine("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10000;
int number2 = number / 1000 % 10; 
int number4 = number % 100 / 10;
int number5 = number % 10;
if((number.ToString().Length) != 5)
{
    Console.WriteLine("Ошибка! Введите положительное пятизначное число");
}
else if (number1 == number5 && number2 == number4)
{
    Console.WriteLine("Число " + number + " Палиндром");
}
else
{
    Console.WriteLine("Число " + number + " не палиндром");
}

