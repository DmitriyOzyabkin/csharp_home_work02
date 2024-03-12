//  Задача 3: Напишите программу, которая принимает на вход
//  целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.Write("Введите число из диапазона [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number > 99)
{
    Console.Write("Введенное число вне допустимого диапазона");
}
else
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.Write($"Наибольшая цифра {firstDigit}");
    }
    else if (firstDigit < secondDigit)
    {
        Console.Write($"Наибольшая цифра {secondDigit}");
    }
    else
    {
        Console.Write("Цифры равны");
    }
}