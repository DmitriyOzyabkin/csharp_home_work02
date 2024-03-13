//  Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.




Console.Write("Enter number: ");
int initNumber = Convert.ToInt32(Console.ReadLine());
if (initNumber < 0)                     // Проверка на отрицательное число
{
    initNumber *= -1;
}

int lastDigit = initNumber % 10;

if (initNumber < 10)
{
    Console.Write(initNumber);          // Вывод числа в консоль, если оно меньше 10
}
else
{
    while (initNumber > 10)
    {
        int rang = 1;                     // Переменная разряда числа
        int currentNumber = initNumber;   // Переменная для сравнения, в операции поиска 0 в разряде
        int digit = initNumber;
        while (digit > 9)                // Нахождение числа в старшем разряде
        {
            if (digit / 10 != 0)
            {
                rang *= 10;
                digit /= 10;
            }
        }
        Console.Write($"{digit}, ");    // выаод числа из старшего разряда
        currentNumber -= digit * rang;
        if (currentNumber < rang / 10)  // проверка на был ли 0 в старшем разряде
        {
            Console.Write(0);
            Console.Write(", ");
        }
        initNumber -= digit * rang;     // вычитание из входного числа старшего разряда
    }
    if (lastDigit != 0)
    {
        Console.Write(lastDigit);       // вывод младнего разряда без "," , если он не 0
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
