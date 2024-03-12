// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


// Проверка только на основное условие

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write("Даное число одновременно кратно 7 и 23");
}
else
{
    Console.Write("Данное число не удовлетворяет условиям");
}


// Проверка на все условия

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.Write("Даное число одновременно кратно 7 и 23");
// }
// else if (number % 7 == 0 && number % 23 != 0)
// {
//     Console.Write("Данное число кратно только 7");
// }
// else if (number % 7 != 0 && number % 23 == 0)
// {
//     Console.Write("Данное число кратно только 23");
// }
// else
// {
//     Console.Write("Данное число не удовлетворяет ни одному из условий");
// }

