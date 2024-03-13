﻿//  Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.


Console.Write("Enter number: ");
int initNumber = Convert.ToInt32(Console.ReadLine());

int rang = 0;
int number = initNumber;
while (number > 0)                          // опредеряем разрядность числа
{
    number /= 10;
    rang++;
}
Console.WriteLine($"Rang = {rang}");

while (rang > 0)                            // Цикл по разрядам числа со старшего до младшего                        
{
    if (rang != 1)                          // Проверка на младший разряд, что бы не вывести его в консоль с ","                         
    {
        number = initNumber;               
        int i = 0;
        while (i < rang)                    // Цикл для вывода в консоль каждого разряда, начиная со старшего
        {
            int digit = number % 10;        // запись в digit крайнего левого числа
            if (i == rang - 1)              // Если условие верно, то в digit лежит число искомого разряда, выводим его в консоль
            {
                Console.Write(digit);
                Console.Write(", ");
            }
            number /= 10;                   // Отбрасываем последний разряд
            i++;                            // Переход к следуюему разряду       
        }
        rang--;                             // Если старший разряд найден, переходим к поиску следующего разряда ниже
    }
    else                                    // Вывод в консоль младшего разряда без ","
    {
        Console.Write(initNumber % 10);
        rang--;
    }
}








// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }
