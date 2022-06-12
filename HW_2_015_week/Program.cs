/* Задача 15: Напишите программу, */
Console.WriteLine("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 5 && number < 8)
    {
        Console.WriteLine("Да");
    }
    else if(number <= 7)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите день недели");
    }
